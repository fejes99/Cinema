using Cinema.Application.Abstractions;

namespace Cinema.Application.Common.Projections.Exceptions;

public class ProjectionIsSoldException : ApplicationLayerException
{
    public ProjectionIsSoldException(string? message) : base(message)
    {
    }
}
