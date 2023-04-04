using Cinema.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Users.Exceptions;

public class UsernameRegexException : DomainException
{
    public UsernameRegexException(string message) : base(message)
    {
    }
}
