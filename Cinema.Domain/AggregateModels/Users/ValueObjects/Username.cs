using Cinema.Domain.AggregateModels.Users.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Users.ValueObjects;

public record Username
{
    private const string usernamePattern = "^[a-zA-Z0-9]*$";
    public string Value { get; init; }
    private Username(string value) => Value = value;

    public static Username Create(string value)
    {
        if (!System.Text.RegularExpressions.Regex.IsMatch(value, usernamePattern)) throw new UsernameRegexException("Username must contain only letters and numbers without spaces.");
        return new Username(value);
    }
}
