using Cinema.Application.Common.Theaters.ProjectionTypes.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Theaters.ProjectionTypes.UseCases;

public interface IProjectionTypeUseCase
{
    Task<List<ProjectionTypeDto>> GetProjectionTypes();
}
