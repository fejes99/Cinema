using Cinema.Domain.AggregateModels.Projections;
using Cinema.Domain.AggregateModels.Projections.ProjectionTypes;
using Cinema.Domain.AggregateModels.Theaters.Seats;
using Cinema.Domain.AggregateModels.Theaters.ValueObjects;

namespace Cinema.Domain.AggregateModels.Theaters;

public class Theater
{
    public TheaterId Id { get; private set; }
    public TheaterName Name { get; private set; }
    public List<ProjectionType> ProjectionTypes { get; private set; } = new();
    public List<Seat> Seats { get; private set; } = new();
    public List<Projection> Projections { get; private set; } = new();

    private Theater(TheaterId id, TheaterName name)
    {
        Id = id;
        Name = name;
    }
    public static Theater Seed(TheaterId id, TheaterName name) => new(id, name);
}
