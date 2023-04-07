using Cinema.Application.Abstractions;

namespace Cinema.Application.Common.Movies.Exceptions;

public class MovieIdArgumentException : ApplicationLayerException
{
    public MovieIdArgumentException(string? message) : base(message)
    {
    }
}
