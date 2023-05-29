using Cinema.Application.Abstractions;

namespace Cinema.Application.Common.Auth.Exceptions;

public class InvalidPasswordException : ApplicationLayerException
{
    public InvalidPasswordException(string? message) : base(message)
    {
    }
}
