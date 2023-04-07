using Cinema.Domain.Abstractions;

namespace Cinema.Domain.AggregateModels.Movies.Exceptions;

public class MovieDurationRangeException : DomainException
{
    public MovieDurationRangeException(string message) : base(message)
    {
    }
}
