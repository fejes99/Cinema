using Cinema.Application.Common.Auth.Dtos;
using Cinema.Application.Common.Auth.UseCases;
using Cinema.Application.Common.Users.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using Cinema.Domain.AggregateModels.Users.ValueObjects;

namespace Cinema.Presentation.Controllers;

[Route("api/auth")]
[AllowAnonymous]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthUseCase authUseCase;
    private readonly HttpClient httpClient;

    public AuthController(IAuthUseCase authUseCase, IHttpClientFactory httpClientFactory)
    {
        this.authUseCase = authUseCase;
        this.httpClient = httpClientFactory.CreateClient();
    }

    [HttpPost("register")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<UserDto>> Register([FromBody] RegisterDataDto registerDataDto)
    {
        UserDto response = await authUseCase.Register(registerDataDto);
        return Created("User registered", response);
    }

    [HttpPost("login")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<LoginResponseDto>> Login([FromBody] LoginDataDto loginDataDto)
    {
        UserDto user = await authUseCase.Login(loginDataDto);

        if (user != null)
        {
            var tokenRequest = new HttpRequestMessage(HttpMethod.Post, "https://localhost:7180/api/identity/token");
            var requestBody = new
            {
                userId = user.Id.ToString(),
                firstName = user.FirstName,
                lastName = user.LastName,
                username = user.Username,
                created = user.Created,
                role = user.Role,
                email = loginDataDto.Email,
                password = loginDataDto.Password
            };
            tokenRequest.Content = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

            var tokenResponse = await httpClient.SendAsync(tokenRequest);

            if (tokenResponse.IsSuccessStatusCode)
            {
                var token = await tokenResponse.Content.ReadAsStringAsync();

                return Ok(new LoginResponseDto { User = user, Token = token });
            }
        }

        return BadRequest();
    }

    [Authorize]
    [HttpPost("logout")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Logout()
    {
        authUseCase.Logout();
        return Ok();
    }
}
