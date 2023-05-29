using Cinema.Infrastructure.Abstractions;

namespace Cinema.Infrastructure.Common.Movies.Exceptions;

public class MovieDontExistException : InfrastructureException
{
    public MovieDontExistException(string message) : base(message)
    {
    }
}
