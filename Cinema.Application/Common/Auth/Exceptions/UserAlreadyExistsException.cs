using Cinema.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Auth.Exceptions;

public class UserAlreadyExistsException : ApplicationLayerException
{
    public UserAlreadyExistsException(string? message) : base(message)
    {
    }
}
