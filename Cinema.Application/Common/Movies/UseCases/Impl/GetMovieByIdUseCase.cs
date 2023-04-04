using Cinema.Application.Abstractions;
using Cinema.Application.Common.Movies.Dtos;
using Cinema.Application.Common.Movies.Exceptions;
using Cinema.Application.Common.Movies.Helpers;
using Cinema.Domain.AggregateModels.Movies;
using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Movies.UseCases.Impl;

public class GetMovieByIdUseCase : IGetMovieByIdUseCase
{
    private IMovieRepository repository;
    public GetMovieByIdUseCase(IMovieRepository repository)
    {
        this.repository = repository;
    }

    public async Task<MovieDto> Execute(Guid request)
    {
        if (request == Guid.Empty) throw new MovieIdArgumentException("MovieId argument dont exist");

        Movie movie = await repository.GetByIdAsync(new MovieId(request));
        if (movie == null) throw new MovieDontExistException("Movie with that id dont exist");

        MovieDto movieDto = movie.MovieToDto();
        return movieDto;
    }
}
