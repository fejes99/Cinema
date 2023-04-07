using Cinema.Domain.Abstractions;

namespace Cinema.Domain.AggregateModels.Projections.Exceptions;

public class ProjectionPriceRangeException : DomainException
{
    public ProjectionPriceRangeException(string message) : base(message)
    {
    }
}
