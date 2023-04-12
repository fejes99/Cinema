using Cinema.Application.Common.Projections.ProjectionTypes.Dtos;
using Cinema.Application.Common.Projections.ProjectionTypes.Helpers;
using Cinema.Domain.AggregateModels.Projections.ProjectionTypes;

namespace Cinema.Application.Common.Projections.ProjectionTypes.UseCases.Impl
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
