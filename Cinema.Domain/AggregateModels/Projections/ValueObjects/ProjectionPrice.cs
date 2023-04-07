using Cinema.Domain.AggregateModels.Projections.Exceptions;

namespace Cinema.Domain.AggregateModels.Projections.ValueObjects;

public record ProjectionPrice
{
    private const int minPrice = 0;
    public int Value { get; init; }
    
    private ProjectionPrice(int value) => Value = value;

    public static ProjectionPrice Create(int value)
    {
        if (value < minPrice) throw new ProjectionPriceRangeException($"Movie duration must be greater than {minPrice}.");
        return new ProjectionPrice(value);
    }
}
