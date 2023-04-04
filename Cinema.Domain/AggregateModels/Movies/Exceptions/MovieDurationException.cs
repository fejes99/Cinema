using Cinema.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Movies.Exceptions;

public class MovieDurationException : DomainException
{
    public MovieDurationException(string message) : base(message)
    {
    }
}
