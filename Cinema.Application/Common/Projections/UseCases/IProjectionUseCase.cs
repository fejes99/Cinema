using Cinema.Application.Common.Projections.Dtos;

namespace Cinema.Application.Common.Projections.UseCases;

public interface IProjectionUseCase
{
    Task<List<ProjectionDto>> GetProjections();
    Task<ProjectionDetailsDto> GetProjectionById(Guid id);
    Task<ProjectionCreateDto> CreateProjection(ProjectionCreateDto projectionCreateDto);
    Task<ProjectionDto> UpdateProjection(Guid id, ProjectionUpdateDto projectionUpdateDto);
    Task DeleteProjection(Guid id);
}
