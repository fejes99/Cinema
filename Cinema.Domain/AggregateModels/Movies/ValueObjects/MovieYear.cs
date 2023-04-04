using Cinema.Domain.AggregateModels.Movies.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Movies.ValueObjects;

public record MovieYear
{
    private const int minValue = 1;
    public int Value { get; init; }
    private MovieYear(int value) => Value = value;

    public static MovieYear Create(int value)
    {
        if (value <= minValue) throw new MovieYearException($"{nameof(MovieYear)} must be greater than {minValue}.");
        return new MovieYear(value);
    }
}
