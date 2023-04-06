using Cinema.Application.Common.Movies.Dtos;
using Cinema.Application.Common.Movies.UseCases;
using Microsoft.AspNetCore.Http;
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
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<MovieDto>>> GetMovies()
    {
        try
        {
            List<MovieDto> movies = await movieUseCase.GetMovies();
            return Ok(movies);
        }
        catch (Exception exception)
        {
            return NotFound(exception.Message);
        }
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<MovieDto>> GetMovie([Required] Guid id)
    {
        try
        {
            MovieDto movie = await movieUseCase.GetMovieById(id);
            return Ok(movie);
        }
        catch (Exception exception)
        {
            return NotFound(exception.Message);
        }
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<MovieDto>> CreateMovie([FromBody] MovieCreateDto movieCreateDto)
    {
        try
        {
            MovieDto createdMovie = await movieUseCase.CreateMovie(movieCreateDto);
            return Created("Movie created", createdMovie);
        }
        catch (Exception exception)
        {
            return NotFound(exception.Message);
        }
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<MovieDto>> UpdateMovie([Required] Guid id, [FromBody] MovieUpdateDto movieUpdateDto)
    {
        try
        {
            MovieDto updatedMovie = await movieUseCase.UpdateMovie(id, movieUpdateDto);
            return Ok(updatedMovie);
        }
        catch(Exception exception)
        {
            return NotFound(exception.Message);
        }
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteMovie([Required] Guid id)
    {
        try
        {
            await movieUseCase.DeleteMovie(id);
            return NoContent();
        }
        catch (Exception exception)
        {
            return NotFound(exception.Message);
        }
    }
}
