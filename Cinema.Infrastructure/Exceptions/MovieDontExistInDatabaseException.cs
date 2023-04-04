using Cinema.Infrastructure.Abstractions;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Exceptions
{
    internal class MovieDontExistInDatabaseException : InfrastructureException
    {
        public MovieDontExistInDatabaseException(string message) : base(message)
        {
        }
    }
}
