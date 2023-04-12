using Cinema.Domain.AggregateModels.Projections.Exceptions;

namespace Cinema.Domain.AggregateModels.Projections.ValueObjects;

public record ProjectionTime
{
    public DateTime Value { get; init; }

    private ProjectionTime(DateTime value) => Value = value;

    public static ProjectionTime Create(DateTime value)
    {
        if (value < DateTime.UtcNow)
        {
            throw new ProjectionTimeRangeException("Projection time cannot be in the past");
        }
        return new ProjectionTime(value);
    }


    public override string ToString() => Value.ToString("ss:mm:hh dd/MM/yyyy");

}
