using Cinema.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Movies.Exceptions;

public class MovieYearException : DomainException
{
    public MovieYearException(string message) : base(message)
    {
    }
}
