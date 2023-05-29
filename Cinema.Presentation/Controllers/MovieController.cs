using Cinema.Application.Common.Movies.Dtos;
using Cinema.Application.Common.Movies.UseCases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Presentation.Controllers;

[Route("api/movies")]
[ApiController]
public class MovieController : ControllerBase
{
    private readonly IMovieUseCase movieUseCase;

    public MovieController(IMovieUseCase movieUseCase)
    {
        this.movieUseCase = movieUseCase;
    }

    [HttpGet]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<MovieDto>>> GetMovies()
    {

        List<MovieDto> movies = await movieUseCase.GetMovies();
        return Ok(movies);
    }

    [HttpGet("{id}")]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<MovieDto>> GetMovie([Required] Guid id)
    {
        MovieDto movie = await movieUseCase.GetMovieById(id);
        return Ok(movie);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<MovieDto>> CreateMovie([FromBody] MovieCreateDto movieCreateDto)
    {
        MovieDto createdMovie = await movieUseCase.CreateMovie(movieCreateDto);
        return Created("Movie created", createdMovie);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<MovieDto>> UpdateMovie([Required] Guid id, [FromBody] MovieUpdateDto movieUpdateDto)
    {
        MovieDto updatedMovie = await movieUseCase.UpdateMovie(id, movieUpdateDto);
        return Ok(updatedMovie);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteMovie([Required] Guid id)
    {
        await movieUseCase.DeleteMovie(id);
        return NoContent();
    }
}
