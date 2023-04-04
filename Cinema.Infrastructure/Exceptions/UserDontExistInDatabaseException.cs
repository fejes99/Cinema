using Cinema.Infrastructure.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Exceptions;

public class UserDontExistInDatabaseException : InfrastructureException
{
    public UserDontExistInDatabaseException(string message) : base(message)
    {
    }
}
