using Cinema.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Movies.Exceptions;

public class MovieIsDeletedAlreadyException : DomainException
{
    public MovieIsDeletedAlreadyException(string message) : base(message)
    {
    }
}
