using Cinema.Domain.Abstractions;

namespace Cinema.Domain.AggregateModels.Users.Exceptions;

public class EmailRegexException : DomainException
{
    public EmailRegexException(string message) : base(message)
    {
    }
}
