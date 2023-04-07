using Cinema.Domain.Abstractions;

namespace Cinema.Domain.AggregateModels.Users.Exceptions;

public class UsernameRegexException : DomainException
{
    public UsernameRegexException(string message) : base(message)
    {
    }
}
