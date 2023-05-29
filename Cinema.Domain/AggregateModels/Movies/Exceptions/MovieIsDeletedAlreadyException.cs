using Cinema.Domain.Abstractions;

namespace Cinema.Domain.AggregateModels.Movies.Exceptions;

public class MovieIsDeletedAlreadyException : DomainException
{
    public MovieIsDeletedAlreadyException(string message) : base(message)
    {
    }
}
