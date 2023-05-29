namespace Cinema.Domain.AggregateModels.Movies.ValueObjects;

public record MovieYear
{
    private const int minValue = 1900;
    public int Value { get; init; }
    private MovieYear(int value) => Value = value;

    public static MovieYear Create(int value)
    {
        return new MovieYear(value);
    }
}
