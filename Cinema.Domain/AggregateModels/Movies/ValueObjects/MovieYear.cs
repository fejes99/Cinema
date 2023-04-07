using Cinema.Domain.AggregateModels.Movies.Exceptions;

namespace Cinema.Domain.AggregateModels.Movies.ValueObjects;

public record MovieYear
{
    private const int minValue = 1900;
    public int Value { get; init; }
    private MovieYear(int value) => Value = value;

    public static MovieYear Create(int value)
    {
        if (value <= minValue) throw new MovieYearRangeException($"{nameof(MovieYear)} must be greater than {minValue}.");
        if (value > DateTime.Now.Year) throw new MovieYearRangeException($"{nameof(MovieYear)} cannot be in the future.");
        return new MovieYear(value);
    }
}
