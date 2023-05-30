using Cinema.Application.Abstractions;

namespace Cinema.Application.Common.Projections.Exceptions;

public class ProjectionTimeException : ApplicationLayerException
{
    public ProjectionTimeException(string? message) : base(message)
    {
    }
}
