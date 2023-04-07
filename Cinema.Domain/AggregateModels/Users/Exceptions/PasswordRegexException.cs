using Cinema.Domain.Abstractions;

namespace Cinema.Domain.AggregateModels.Users.Exceptions;

public class PasswordRegexException : DomainException
{
    public PasswordRegexException(string message) : base(message)
    {
    }
}
