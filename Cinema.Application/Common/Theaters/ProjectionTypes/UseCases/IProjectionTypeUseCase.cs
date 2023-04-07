using Cinema.Application.Common.Theaters.ProjectionTypes.Dtos;

namespace Cinema.Application.Common.Theaters.ProjectionTypes.UseCases;

public interface IProjectionTypeUseCase
{
    Task<List<ProjectionTypeDto>> GetProjectionTypes();
}
