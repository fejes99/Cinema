using Cinema.Application.Common.Movies.Dtos;
using Cinema.Domain.AggregateModels.Movies;
using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Movies.Helpers;

public static class MovieMapper
{
    public static MovieDto MovieToDto(this Movie movie)
    {
        return new MovieDto
        {
            Name = movie.Name.Value,
            Director = movie.Director.Value,
            Duration = movie.Duration.Value,
            Distributor = movie.Distributor.Value,
            Country = movie.Country.Value,
            Year = movie.Year.Value,
            Description = movie.Description.Value
        };
    }

    public static Movie DtoToMovie(this MovieDto movieDto)
    {
        MovieName name = new MovieName(movieDto.Name);
        MovieDirector director = MovieDirector.Create(movieDto.Director);
        MovieDuration duration = MovieDuration.Create(movieDto.Duration);
        MovieDistributor distributor = new MovieDistributor(movieDto.Distributor);
        MovieCountry country = new MovieCountry(movieDto.Country);
        MovieYear year = MovieYear.Create(movieDto.Year);
        MovieDescription description = MovieDescription.Create(movieDto.Description);


        return Movie.Create(name, director, duration, distributor, country, year, description);
    }

    public static MovieCreateDto MovieDtoToCreateDto(this MovieDto movieDto)
    {
        return new MovieCreateDto
        {
            Name = movieDto.Name,
            Director = movieDto.Director,
            Duration = movieDto.Duration,
            Distributor = movieDto.Distributor,
            Country = movieDto.Country,
            Year = movieDto.Year,
            Description = movieDto.Description
        };
    }

    public static Movie CreateDtoToModel(this MovieCreateDto movieCreateDto)
    {
        MovieName name = new MovieName(movieCreateDto.Name);
        MovieDirector director = MovieDirector.Create(movieCreateDto.Director);
        MovieDuration duration = MovieDuration.Create(movieCreateDto.Duration);
        MovieDistributor distributor = new MovieDistributor(movieCreateDto.Distributor);
        MovieCountry country = new MovieCountry(movieCreateDto.Country);
        MovieYear year = MovieYear.Create(movieCreateDto.Year);
        MovieDescription description = MovieDescription.Create(movieCreateDto.Description);


        return Movie.Create(name, director, duration, distributor, country, year, description);
    }

    public static Movie UpdateDtoToMovie(this MovieUpdateDto movieUpdateDto)
    {
        MovieName name = new MovieName(movieUpdateDto.Name);
        MovieDirector director = MovieDirector.Create(movieUpdateDto.Director);
        MovieDuration duration = MovieDuration.Create((int)movieUpdateDto.Duration);
        MovieDistributor distributor = new MovieDistributor(movieUpdateDto.Distributor);
        MovieCountry country = new MovieCountry(movieUpdateDto.Country);
        MovieYear year = MovieYear.Create((int)movieUpdateDto.Year);
        MovieDescription description = MovieDescription.Create(movieUpdateDto.Description);


        return Movie.Create(name, director, duration, distributor, country, year, description);
    }

    public static Movie UpdateMapper(this Movie movie, MovieUpdateDto movieUpdateDto)
    {
        MovieName? name = null;
        MovieDirector? director = null;
        MovieDuration? duration = null;
        MovieDistributor? distributor = null;
        MovieCountry? country = null;
        MovieYear? year = null;
        MovieDescription? description = null;

        if (!string.IsNullOrEmpty(movieUpdateDto.Name)) name = new MovieName(movieUpdateDto.Name);
        if (!string.IsNullOrEmpty(movieUpdateDto.Director)) director = MovieDirector.Create(movieUpdateDto.Director);
        if (movieUpdateDto.Duration > 0) duration = MovieDuration.Create((int)movieUpdateDto.Duration);
        if (!string.IsNullOrEmpty(movieUpdateDto.Distributor)) distributor = new MovieDistributor(movieUpdateDto.Distributor);
        if (!string.IsNullOrEmpty(movieUpdateDto.Country)) country = new MovieCountry(movieUpdateDto.Country);
        if (movieUpdateDto.Year > 1) year = MovieYear.Create((int)movieUpdateDto.Year);
        if (!string.IsNullOrEmpty(movieUpdateDto.Description)) description = MovieDescription.Create(movieUpdateDto.Description);

        movie.Update(name, director, duration, distributor, country, year, description);
        return movie;
    }
}
