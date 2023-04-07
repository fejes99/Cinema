using Cinema.Infrastructure.Abstractions;

namespace Cinema.Infrastructure.Common.Users.Exceptions;

public class UserDontExistInDatabaseException : InfrastructureException
{
    public UserDontExistInDatabaseException(string message) : base(message)
    {
    }
}
