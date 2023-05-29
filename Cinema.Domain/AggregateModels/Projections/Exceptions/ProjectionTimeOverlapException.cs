using Cinema.Domain.Abstractions;

namespace Cinema.Domain.AggregateModels.Projections.Exceptions;

internal class ProjectionTimeOverlapException : DomainException
{
    public ProjectionTimeOverlapException(string message) : base(message)
    {
    }
}
