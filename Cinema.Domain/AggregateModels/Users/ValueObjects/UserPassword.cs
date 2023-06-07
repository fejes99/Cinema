
using BCrypt.Net;
using Cinema.Domain.AggregateModels.Users.Exceptions;

namespace Cinema.Domain.AggregateModels.Users.ValueObjects;

public record UserPassword
{
    private const string PasswordPattern = @"^[a-zA-Z0-9]*$";
    public string Value { get; init; }
    private UserPassword(string value) => Value = value;

    public static UserPassword Create(string value)
    {
        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(value);
        return new UserPassword(hashedPassword);
    }
}
