using Cinema.Domain.Abstractions;

namespace Cinema.Domain.AggregateModels.Projections.Exceptions;

public class ProjectionIsDeletedAlreadyException : DomainException
{
    public ProjectionIsDeletedAlreadyException(string message) : base(message)
    {
    }
}
