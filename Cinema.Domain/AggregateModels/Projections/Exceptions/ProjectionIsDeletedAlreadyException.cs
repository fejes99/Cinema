using Cinema.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Projections.Exceptions;

public class ProjectionIsDeletedAlreadyException : DomainException
{
    public ProjectionIsDeletedAlreadyException(string message) : base(message)
    {
    }
}
