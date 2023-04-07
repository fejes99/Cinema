using Cinema.Application.Abstractions;

namespace Cinema.Application.Common.Movies.Exceptions;

public class MovieNotFoundException : ApplicationLayerException
{
    public MovieNotFoundException(string? message) : base(message)
    {
    }
}
