﻿using Cinema.Domain.AggregateModels.Movies;
using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Infrastructure.Common.Movies.Repositories;

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
        return await context.Movies
            .Include(movie => movie.Projections)
            .ThenInclude(projection => projection.ProjectionType)
            .ThenInclude(projection => projection.Theaters)
            .ToListAsync();
    }

    public async Task<Movie> GetByIdAsync(MovieId movieId)
    {
        var movie = await context.Movies
            .Include(movie => movie.Projections)
            .FirstOrDefaultAsync(movie => movie.Id == movieId);
        return movie ?? new Movie();
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
