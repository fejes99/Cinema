﻿using Cinema.Application.Abstractions;
using Cinema.Application.Common.Movies.Dtos;
using Cinema.Application.Common.Movies.Helpers;
using Cinema.Domain.AggregateModels.Movies;
using Cinema.Domain.AggregateModels.Movies.ValueObjects;

namespace Cinema.Application.Common.Movies.UseCases.Impl;

public class MovieUseCase : IMovieUseCase
{
    private readonly IMovieRepository repository;

    public MovieUseCase(IMovieRepository repository)
    {
        this.repository = repository;
    }

    public async Task<MovieDto> CreateMovie(MovieCreateDto movieCreateDto)
    {
        Movie createdMovie = await repository.CreateAsync(movieCreateDto.CreateDtoToMovie());
        MovieDto createdMovieDto = createdMovie.MovieToDto();
        return createdMovieDto;
    }

    public async Task DeleteMovie(Guid id)
    {
        Movie movie = await repository.GetByIdAsync(new MovieId(id));
        if (movie.HasDefaultValues()) throw new NotFoundException("Movie with that id dont exist");
        movie.Delete();
        
        if(movie.IsDeleted)
        {
            await repository.UpdateAsync(movie);
        } 
        else
        {
            await repository.DeleteAsync(movie);
        }  
    }

    public async Task<List<MovieDto>> GetMovies()
    {
        List<Movie> movies = await repository.GetAllAsync();
        List<MovieDto> movieDtos = movies.Select(movie => movie.MovieToDto()).ToList();
        return movieDtos;
    }

    public async Task<MovieDto> GetMovieById(Guid id)
    {
        Movie movie = await repository.GetByIdAsync(new MovieId(id));
        if (movie.HasDefaultValues()) throw new NotFoundException("Movie with that id dont exist");

        MovieDto movieDto = movie.MovieToDto();
        return movieDto;
    }

    public async Task<MovieDto> UpdateMovie(Guid id, MovieUpdateDto movieUpdateDto)
    {
        Movie movieToUpdate = await repository.GetByIdAsync(new MovieId(id));
        Movie updatedMovie = await repository.UpdateAsync(movieToUpdate.UpdateMapper(movieUpdateDto));
        MovieDto updatedMovieDto = updatedMovie.MovieToDto();
        return updatedMovieDto;
    }
}
