using Cinema.Infrastructure.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Common.Movies.Exceptions;

public class MovieDontExistException : InfrastructureException
{
    public MovieDontExistException(string message) : base(message)
    {
    }
}
