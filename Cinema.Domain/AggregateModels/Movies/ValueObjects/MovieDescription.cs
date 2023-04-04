using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Movies.ValueObjects;

public record MovieDescription
{
    public string Value { get; init; }
    private MovieDescription(string value) => Value = value;
    public static MovieDescription? Create(string value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        return new MovieDescription(value);
    }
}
