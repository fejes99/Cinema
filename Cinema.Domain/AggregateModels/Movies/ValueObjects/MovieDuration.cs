
using Cinema.Domain.AggregateModels.Movies.Exceptions;

namespace Cinema.Domain.AggregateModels.Movies.ValueObjects;

public record MovieDuration
{
    private const int minDuration = 1;
    private const int maxDuration = 500;
    public int Value { get; init; }

    private MovieDuration(int value) => Value = value;

    public static MovieDuration Create(int value)
    {
        if (value <= minDuration) throw new MovieDurationRangeException($"Movie duration must be greater than {minDuration}.");
        if (value > maxDuration) throw new MovieDurationRangeException($"Movie duration cannot be greater than {maxDuration}.");
        return new MovieDuration(value);
    }
}
