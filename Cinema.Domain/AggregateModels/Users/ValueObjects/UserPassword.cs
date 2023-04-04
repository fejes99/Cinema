using Cinema.Domain.AggregateModels.Users.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Users.ValueObjects;

public record UserPassword
{
    private const string passwordPattern = @"^[a-zA-Z0-9]*$";
    public string Value { get; init; }
    private UserPassword(string value) => Value = value;

    public static UserPassword Create(string value)
    {
        if (!System.Text.RegularExpressions.Regex.IsMatch(value, passwordPattern)) throw new PasswordRegexException("Password must contain only letters and numbers without space!");
        return new UserPassword(value);
    }
}
