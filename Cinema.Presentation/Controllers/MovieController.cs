using Cinema.Application.Common.Movies.Dtos;
using Cinema.Application.Common.Movies.UseCases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Presentation.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IGetMoviesUseCase getMoviesUseCase;
        private readonly IGetMovieByIdUseCase getMovieByIdUseCase;

        public MovieController(IGetMoviesUseCase getMoviesUseCase, IGetMovieByIdUseCase getMovieByIdUseCase)
        {
            this.getMoviesUseCase = getMoviesUseCase;
            this.getMovieByIdUseCase = getMovieByIdUseCase;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<MovieDto>>> GetMovies()
        {
            try
            {
                List<MovieDto> movies = await getMoviesUseCase.Execute(null);
                return Ok(movies);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MovieDto>> GetMovie([Required] Guid id)
        {
            try
            {
                var movie = await getMovieByIdUseCase.Execute(id);
                return Ok(movie);
            }
            catch (HttpRequestException exception)
            {
                return NotFound(exception.Message);
            }
        }
    }
}
