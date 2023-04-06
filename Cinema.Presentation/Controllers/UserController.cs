using Cinema.Application.Common.Movies.Dtos;
using Cinema.Application.Common.Movies.UseCases;
using Cinema.Application.Common.Movies.UseCases.Impl;
using Cinema.Application.Common.Users.Dtos;
using Cinema.Application.Common.Users.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Presentation.Controllers;

[Route("api/users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserUseCase userUseCase;

    public UserController(IUserUseCase userUseCase)
    {
        this.userUseCase = userUseCase;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<UserDto>>> GetUsers()
    {
        try
        {
            List<UserDto> users = await userUseCase.GetUsers();
            return Ok(users);
        }
        catch (Exception exception)
        {
            return NotFound(exception.Message);
        }
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UserDto>> GetUser([Required] Guid id)
    {
        try
        {
            UserDto user = await userUseCase.GetUserById(id);
            return Ok(user);
        }
        catch (Exception exception)
        {
            return NotFound(exception.Message);
        }
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<UserDto>> CreateUser([FromBody] UserCreateDto userCreateDto)
    {
        try
        {
            UserDto createdUser = await userUseCase.CreateUser(userCreateDto);
            return Created("Movie created", createdUser);
        }
        catch (Exception exception)
        {
            return NotFound(exception.Message);
        }
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UserDto>> UpdateUser([Required] Guid id, [FromBody] UserUpdateDto userUpdateDto)
    {
        try
        {
            UserDto updatedUser = await userUseCase.UpdateUser(id, userUpdateDto);
            return Ok(updatedUser);
        }
        catch (Exception exception)
        {
            return NotFound(exception.Message);
        }
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteUser([Required] Guid id)
    {
        try
        {
            await userUseCase.DeleteUser(id);
            return NoContent();
        }
        catch (Exception exception)
        {
            return NotFound(exception.Message);
        }
    }
}
