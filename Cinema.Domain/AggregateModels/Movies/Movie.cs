using Cinema.Domain.AggregateModels.Movies.Exceptions;
using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using Cinema.Domain.AggregateModels.Projections;
using System.Runtime.CompilerServices;

namespace Cinema.Domain.AggregateModels.Movies;

public class Movie
{
    public MovieId Id { get; private set; }
    public MovieName Name { get; private set; }
    public MovieDirector? Director { get; private set; }
    public MovieDuration Duration { get; private set; }
    public MovieDistributor Distributor { get; private set; }
    public MovieCountry Country { get; private set; }
    public MovieYear Year { get; private set; }
    public MovieTrailerUrl? TrailerUrl { get; private set; }
    public MovieDescription? Description { get; private set; }
    public bool IsDeleted { get; private set; }
    public List<Projection> Projections { get; private set; } = new();

    public Movie()
    {
        Id = new MovieId(Guid.NewGuid());
        Name = new MovieName("");
        Duration = MovieDuration.Create(2);
        Distributor = new MovieDistributor("");
        Country = new MovieCountry("");
        Year = MovieYear.Create(DateTime.Now.Year);
        IsDeleted = false;
    }

    private Movie(MovieName name,
        MovieDirector? director,
        MovieDuration duration,
        MovieDistributor distributor,
        MovieCountry country,
        MovieYear year,
        MovieTrailerUrl? trailerUrl,
        MovieDescription? description)
    {
        Id = new MovieId(Guid.NewGuid());
        Name = name;
        Director = director;
        Duration = duration;
        Distributor = distributor;
        Country = country;
        Year = year;
        TrailerUrl = trailerUrl;
        Description = description;
        IsDeleted = false;
    }

    public static Movie Create(
        MovieName name,
        MovieDirector? director,
        MovieDuration duration,
        MovieDistributor distributor,
        MovieCountry country,
        MovieYear year,
        MovieTrailerUrl? trailerUrl,
        MovieDescription? description)
    => new(name, director, duration, distributor, country, year, trailerUrl, description);

    public void Update(
        MovieName? name = null,
        MovieDirector? director = null,
        MovieDuration? duration = null,
        MovieDistributor? distributor = null,
        MovieCountry? country = null,
        MovieYear? year = null,
        MovieTrailerUrl? trailerUrl = null,
        MovieDescription? description = null)
    {
        if (name != null) Name = name;
        if (director != null) Director = director;
        if (duration != null) Duration = duration;
        if (distributor != null) Distributor = distributor;
        if (country != null) Country = country;
        if (year != null) Year = year;
        if (trailerUrl != null) TrailerUrl = trailerUrl;
        if (description != null) Description = description;
    }

    public void Delete()
    {
        if (IsDeleted) throw new MovieIsDeletedAlreadyException("Movie is already deleted.");
        if (Projections.Any()) IsDeleted = true; 
    }

    public bool HasDefaultValues()
    {
        return Name.Value == "" &&
               Duration.Value == 2 &&
               Distributor.Value == "" &&
               Country.Value == "" &&
               Year.Value == DateTime.Now.Year;
    }
}
