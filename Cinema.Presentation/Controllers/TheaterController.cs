using Cinema.Application.Common.Theaters.Dtos;
using Cinema.Application.Common.Theaters.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Presentation.Controllers;

[Route("api/theaters")]
[AllowAnonymous]
[ApiController]
public class TheaterController : ControllerBase
{
    private readonly ITheaterUseCase theaterUseCase;

    public TheaterController(ITheaterUseCase theaterUseCase)
    {
        this.theaterUseCase = theaterUseCase;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<TheaterDto>>> GetTheaters()
    {
        List<TheaterDto> theaters = await theaterUseCase.GetTheaters();
        return Ok(theaters);
    }
}
