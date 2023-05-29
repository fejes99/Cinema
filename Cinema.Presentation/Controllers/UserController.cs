using Cinema.Application.Common.Users.Dtos;
using Cinema.Application.Common.Users.UseCases;
using Microsoft.AspNetCore.Authorization;
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
        List<UserDto> users = await userUseCase.GetUsers();
        return Ok(users);
    }

    [HttpGet("{id}")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UserDto>> GetUser([Required] Guid id)
    {
        UserDto user = await userUseCase.GetUserById(id);
        return Ok(user);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UserDto>> UpdateUser([Required] Guid id, [FromBody] UserUpdateDto userUpdateDto)
    {
        UserDto updatedUser = await userUseCase.UpdateUser(id, userUpdateDto);
        return Ok(updatedUser);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteUser([Required] Guid id)
    {
        await userUseCase.DeleteUser(id);
        return NoContent();
    }
}
