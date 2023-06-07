using Cinema.Domain.AggregateModels.Movies.Exceptions;

namespace Cinema.Domain.AggregateModels.Movies.ValueObjects;

public record MovieYear
{
    private const int minYear = 1900;
    public int Value { get; init; }
    private MovieYear(int value) => Value = value;

    public static MovieYear Create(int value)
    {
        if (value <= minYear) throw new MovieYearRangeException($"Movie year must be greater than {minYear}.");
        return new MovieYear(value);
    }
}
