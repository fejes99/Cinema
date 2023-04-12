using Cinema.Application.Common.Projections.ProjectionTypes.Dtos;

namespace Cinema.Application.Common.Projections.ProjectionTypes.UseCases;

public interface IProjectionTypeUseCase
{
    Task<List<ProjectionTypeDto>> GetProjectionTypes();
}
