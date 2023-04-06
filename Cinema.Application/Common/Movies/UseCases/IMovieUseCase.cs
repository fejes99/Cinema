using Cinema.Application.Common.Movies.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Movies.UseCases
{
    public interface IMovieUseCase
    {
        Task<List<MovieDto>> GetMovies();
        Task<MovieDto> GetMovieById(Guid id);
        Task<MovieDto> CreateMovie(MovieCreateDto movieCreateDto);
        Task<MovieDto> UpdateMovie(Guid id, MovieUpdateDto movieUpdateDto);
        Task DeleteMovie(Guid id);
    }
}
