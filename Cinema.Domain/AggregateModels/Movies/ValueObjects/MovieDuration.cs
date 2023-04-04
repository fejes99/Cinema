
using Cinema.Domain.AggregateModels.Movies.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Movies.ValueObjects;

public record MovieDuration
{
    private const int minDuration = 1;
    public int Value { get; init; }
    private MovieDuration(int value) => Value = value;

    public static MovieDuration Create(int value)
    {
        if (value <= minDuration) throw new MovieDurationException($"Movie duration must be greater than {minDuration}.");
        return new MovieDuration(value);
    }
}
