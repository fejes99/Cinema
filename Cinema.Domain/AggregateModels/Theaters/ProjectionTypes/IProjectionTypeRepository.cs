using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Theaters.ProjectionTypes;

public interface IProjectionTypeRepository
{
    Task<List<ProjectionType>> GetAllAsync();
}
