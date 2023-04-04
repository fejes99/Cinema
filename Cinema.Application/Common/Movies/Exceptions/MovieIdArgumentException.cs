using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Movies.Exceptions;

public class MovieIdArgumentException : ApplicationException
{
    public MovieIdArgumentException(string? message) : base(message)
    {
    }
}
