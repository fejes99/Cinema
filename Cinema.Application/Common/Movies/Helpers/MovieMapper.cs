using Cinema.Application.Common.Movies.Dtos;
using Cinema.Domain.AggregateModels.Movies;
using Cinema.Domain.AggregateModels.Movies.ValueObjects;

namespace Cinema.Application.Common.Movies.Helpers;

public static class MovieMapper
{
    public static MovieDto MovieToDto(this Movie movie)
    {
        return new MovieDto
        {
            Id = movie.Id.Value,
            Name = movie.Name.Value,
            Director = movie.Director!.Value,
            Duration = movie.Duration.Value,
            Distributor = movie.Distributor.Value,
            Country = movie.Country.Value,
            Year = movie.Year.Value,
            Description = movie.Description!.Value
        };
    }


    public static Movie CreateDtoToMovie(this MovieCreateDto movieCreateDto)
    {
        MovieName name = new MovieName(movieCreateDto.Name);
        MovieDirector director = MovieDirector.Create(movieCreateDto.Director!)!;
        MovieDuration duration = MovieDuration.Create(movieCreateDto.Duration);
        MovieDistributor distributor = new MovieDistributor(movieCreateDto.Distributor);
        MovieCountry country = new MovieCountry(movieCreateDto.Country);
        MovieYear year = MovieYear.Create(movieCreateDto.Year);
        MovieDescription description = MovieDescription.Create(movieCreateDto.Description!)!;


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

        if(!string.IsNullOrEmpty(movieUpdateDto.Name)) name = new MovieName(movieUpdateDto.Name);
        if(!string.IsNullOrEmpty(movieUpdateDto.Director)) director = MovieDirector.Create(movieUpdateDto.Director);
        if(movieUpdateDto.Duration > 0) duration = MovieDuration.Create((int)movieUpdateDto.Duration);
        if(!string.IsNullOrEmpty(movieUpdateDto.Distributor)) distributor = new MovieDistributor(movieUpdateDto.Distributor);
        if(!string.IsNullOrEmpty(movieUpdateDto.Country)) country = new MovieCountry(movieUpdateDto.Country);
        if(movieUpdateDto.Year > 1) year = MovieYear.Create((int)movieUpdateDto.Year);
        if(!string.IsNullOrEmpty(movieUpdateDto.Description)) description = MovieDescription.Create(movieUpdateDto.Description);

        movie.Update(name, director, duration, distributor, country, year, description);
        return movie;
    }
}
