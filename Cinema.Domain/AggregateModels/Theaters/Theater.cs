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

    public bool IsFreeDuring(DateTime startTime, TimeSpan duration)
    {
        DateTime projectionDate = startTime.Date;
        DateTime projectionEndTime = startTime + duration;

        foreach (Projection p in Projections)
        {
            if (p.Time.Value.Date == projectionDate && p.Time.OverlapsWith(startTime, projectionEndTime))
            {
                return false;
            }
        }

        return true;
    }


    public static Theater Seed(TheaterId id, TheaterName name) => new(id, name);
}
