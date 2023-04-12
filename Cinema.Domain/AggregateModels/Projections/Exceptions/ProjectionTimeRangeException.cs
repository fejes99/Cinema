using Cinema.Domain.Abstractions;

namespace Cinema.Domain.AggregateModels.Projections.Exceptions;

public class ProjectionTimeRangeException : DomainException
{
    public ProjectionTimeRangeException(string message) : base(message)
    {
    }
}
