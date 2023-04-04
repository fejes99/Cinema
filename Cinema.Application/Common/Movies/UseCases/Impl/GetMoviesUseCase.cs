using Cinema.Application.Abstractions;
using Cinema.Application.Common.Movies.Dtos;
using Cinema.Application.Common.Movies.Helpers;
using Cinema.Domain.AggregateModels.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Movies.UseCases.Impl;

public class GetMoviesUseCase : IGetMoviesUseCase
{
    private IMovieRepository repository;
    public GetMoviesUseCase(IMovieRepository repository)
    {
        this.repository = repository;
    }

    public async Task<List<MovieDto>> Execute(object request)
    {
        List<Movie> movies = await repository.GetAllAsync();
        List<MovieDto> movieDtos = movies.Select(movie => movie.MovieToDto()).ToList();
        return movieDtos;
    }
}
