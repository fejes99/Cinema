using Cinema.Domain.Abstractions;

namespace Cinema.Domain.AggregateModels.Users.Exceptions;

public class UserRoleException : DomainException
{
    public UserRoleException(string message) : base(message)
    {
    }
}
