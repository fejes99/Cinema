namespace Cinema.Domain.AggregateModels.Projections.ValueObjects;

public record ProjectionTime
{
    public DateTime Value { get; init; }

    private ProjectionTime(DateTime value) => Value = value;

    public static ProjectionTime Create() => new(DateTime.Now);

    public static ProjectionTime CreateWithValue(DateTime value) => new(value);

    public override string ToString() => Value.ToString("ss:mm:hh dd/MM/yyyy");

}
