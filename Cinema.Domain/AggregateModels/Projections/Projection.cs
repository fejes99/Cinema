using Cinema.Domain.AggregateModels.Movies;
using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using Cinema.Domain.AggregateModels.Projections.Exceptions;
using Cinema.Domain.AggregateModels.Projections.ProjectionTypes;
using Cinema.Domain.AggregateModels.Projections.ProjectionTypes.ValueObjects;
using Cinema.Domain.AggregateModels.Projections.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters;
using Cinema.Domain.AggregateModels.Theaters.ValueObjects;
using Cinema.Domain.AggregateModels.Tickets;

namespace Cinema.Domain.AggregateModels.Projections;

public class Projection
{
    public ProjectionId Id { get; private set; }
    public ProjectionTime Time { get; private set; }
    public ProjectionPrice Price { get; private set; }
    public MovieId MovieId { get; private set; }
    public Movie Movie { get; private set; }
    public ProjectionTypeId ProjectionTypeId { get; private set; }
    public ProjectionType ProjectionType { get; private set; }
    public TheaterId TheaterId { get; private set; }
    public Theater Theater { get; private set; }
    public bool IsDeleted { get; private set; }
    public bool IsSold { get; private set; }
    public List<Ticket> Tickets { get; private set; }

    private Projection(
        ProjectionTime time,
        ProjectionPrice price,
        MovieId movieId,
        ProjectionTypeId projectionTypeId,
        TheaterId theaterId)
    {
        Id = new ProjectionId(Guid.NewGuid());
        Time = time;
        Price = price;
        MovieId = movieId;
        ProjectionTypeId = projectionTypeId;
        TheaterId = theaterId;
        IsDeleted = false;
        IsSold = false;
    }

    public static Projection Create(
    ProjectionTime time,
    ProjectionPrice price,
    Movie movie,
    ProjectionTypeId projectionTypeId,
    Theater theater)
    {
        if (!theater.IsFreeDuring(time.Value, TimeSpan.FromMinutes(movie.Duration.Value)))
        {
            throw new ProjectionTimeOverlapException("The theater is not available for the given projection time.");
        }


        var projection = new Projection(time, price, movie.Id, projectionTypeId, theater.Id);
        return projection;
    }


    public void Update(
        ProjectionTime? time = null,
        ProjectionPrice? price = null,
        ProjectionTypeId? projectionTypeId = null,
        TheaterId? theaterId = null)
    {
        if (time != null) Time = time;
        if(price != null) Price = price;
        if(projectionTypeId != null) ProjectionTypeId = projectionTypeId;
        if(theaterId != null) TheaterId = theaterId;
    }

    public void Delete()
    {
        if (IsDeleted) throw new ProjectionIsDeletedAlreadyException("Projection is already deleted.");
        if(Tickets.Any()) IsDeleted = true;
    }

    public bool CanSellTickets()
    {
        return !IsDeleted && !IsSold && Time.Value > DateTime.UtcNow;
    }
}
