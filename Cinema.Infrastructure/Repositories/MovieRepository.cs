
using Cinema.Domain.AggregateModels.Movies;
using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using Cinema.Infrastructure.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly DatabaseContext context;
    public MovieRepository(DatabaseContext context)
    {
        this.context = context;
    }

    public async Task<Movie> CreateAsync(Movie movie)
    {
        await context.AddAsync(movie);
        await SaveChangesAsync();
        return movie;
    }

    public async Task DeleteAsync(Movie movie)
    {
        context.Remove(movie);
        await SaveChangesAsync();
    }


    public async Task<List<Movie>> GetAllAsync()
    {
        return await context.Movies.ToListAsync();
    }

    // Todo: Handle Default
    public async Task<Movie> GetByIdAsync(MovieId movieId)
    {
        var movie =  await context.Movies.FirstOrDefaultAsync(movie => movie.Id == movieId);
        return movie ?? throw new MovieDontExistInDatabaseException("Movie with given Id dont exist in Database");
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<Movie> UpdateAsync(Movie movie)
    {
        context.Update(movie);
        await SaveChangesAsync();
        return movie;
    }
}
