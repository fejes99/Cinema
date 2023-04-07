using Cinema.Domain.Abstractions;

namespace Cinema.Domain.AggregateModels.Movies.Exceptions;

public class MovieYearRangeException : DomainException
{
    public MovieYearRangeException(string message) : base(message)
    {
    }
}
