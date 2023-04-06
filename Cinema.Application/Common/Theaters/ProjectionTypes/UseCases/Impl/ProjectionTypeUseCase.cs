using Cinema.Application.Common.Theaters.ProjectionTypes.Dtos;
using Cinema.Application.Common.Theaters.ProjectionTypes.Helpers;
using Cinema.Domain.AggregateModels.Theaters.ProjectionTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Theaters.ProjectionTypes.UseCases.Impl
{
    public class ProjectionTypeUseCase : IProjectionTypeUseCase
    {
        private readonly IProjectionTypeRepository repository;

        public ProjectionTypeUseCase(IProjectionTypeRepository repository)
        {
            this.repository = repository;
        }

        public async Task<List<ProjectionTypeDto>> GetProjectionTypes()
        {
            List<ProjectionType> projectionTypes = await repository.GetAllAsync();
            List<ProjectionTypeDto> projectionTypeDtos = projectionTypes.Select(projectionType => projectionType.ProjectionTypeToDto()).ToList();
            return projectionTypeDtos;
        }
    }
}
