using Cinema.Application.Common.Projections.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Projections.UseCases;

public interface IProjectionUseCase
{
    Task<List<ProjectionDto>> GetProjections();
    Task<ProjectionDto> GetProjectionById(Guid id);
    Task<ProjectionDto> CreateProjection(ProjectionCreateDto projectionCreateDto);
    Task<ProjectionDto> UpdateProjection(Guid id, ProjectionUpdateDto projectionUpdateDto);
    Task DeleteProjection(Guid id);
}
