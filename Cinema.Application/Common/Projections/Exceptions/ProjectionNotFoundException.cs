using Cinema.Application.Abstractions;

namespace Cinema.Application.Common.Projections.Exceptions;

public class ProjectionNotFoundException : ApplicationLayerException
{
    public ProjectionNotFoundException(string? message) : base(message)
    {
    }
}
