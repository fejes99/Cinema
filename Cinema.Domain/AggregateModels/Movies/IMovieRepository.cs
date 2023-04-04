using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Movies;

public interface IMovieRepository
{
    Task<List<Movie>> GetAllAsync();
    Task<Movie> GetByIdAsync(MovieId movieId);
    Task<Movie> CreateAsync(Movie movie);
    Task<Movie> UpdateAsync(Movie movie);
    Task DeleteAsync(Movie movie);
    Task<bool> SaveChangesAsync();
}
