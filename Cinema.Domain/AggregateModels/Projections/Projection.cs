using Cinema.Domain.AggregateModels.Movies;
using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using Cinema.Domain.AggregateModels.Projections.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters;
using Cinema.Domain.AggregateModels.Theaters.ProjectionTypes;
using Cinema.Domain.AggregateModels.Theaters.ProjectionTypes.ValueObjects;
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
    }

    public static Projection Create(
        ProjectionTime time,
        ProjectionPrice price,
        MovieId movieId,
        ProjectionTypeId projectionTypeId,
        TheaterId theaterId) => new(time, price, movieId, projectionTypeId, theaterId);

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
}
