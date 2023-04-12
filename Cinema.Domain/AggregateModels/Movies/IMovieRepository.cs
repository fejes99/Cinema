using Cinema.Domain.AggregateModels.Movies.ValueObjects;

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
