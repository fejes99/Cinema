using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public MovieDescription? Description { get; private set; }

    public Movie()
    {
        Id = new MovieId(Guid.NewGuid());
        Name = new MovieName("");
        Duration = MovieDuration.Create(2);
        Distributor = new MovieDistributor("");
        Country = new MovieCountry("");
        Year = MovieYear.Create(DateTime.Now.Year);
    }


    private Movie(MovieName name,
        MovieDirector? director,
        MovieDuration duration,
        MovieDistributor distributor,
        MovieCountry country,
        MovieYear year,
        MovieDescription? description)
    {
        Id = new MovieId(Guid.NewGuid());
        Name = name;
        Director = director;
        Duration = duration;
        Distributor = distributor;
        Country = country;
        Year = year;
        Description = description;
    }

    public static Movie Create(
        MovieName name,
        MovieDirector? director,
        MovieDuration duration,
        MovieDistributor distributor,
        MovieCountry country,
        MovieYear year,
        MovieDescription? description)
    => new(name, director, duration, distributor, country, year, description);

    public void Update(
        MovieName? name = null,
        MovieDirector? director = null,
        MovieDuration? duration = null,
        MovieDistributor? distributor = null,
        MovieCountry? country = null,
        MovieYear? year = null,
        MovieDescription? description = null)
    {
        if (name != null) Name = name;
        if (director != null) Director = director;
        if (duration != null) Duration = duration;
        if (distributor != null) Distributor = distributor;
        if (country != null) Country = country;
        if (year != null) Year = year;
        if (description != null) Description = description;
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
