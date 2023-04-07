using Cinema.Application.Common.Projections.Dtos;
using Cinema.Application.Common.Projections.Helpers;
using Cinema.Domain.AggregateModels.Projections;
using Cinema.Domain.AggregateModels.Projections.ValueObjects;
using Cinema.Domain.AggregateModels.Users.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Projections.UseCases.Impl;

public class ProjectionUseCase : IProjectionUseCase
{
    private readonly IProjectionRepository repository;

    public ProjectionUseCase(IProjectionRepository repository)
    {
        this.repository = repository;
    }

    public async Task<ProjectionDto> CreateProjection(ProjectionCreateDto projectionCreateDto)
    {
        Projection createdProjection = await repository.CreateAsync(projectionCreateDto.CreateDtoToProjection());
        ProjectionDto createdProjectionDto = createdProjection.ProjectionToDto();
        return createdProjectionDto;
    }

    public async Task DeleteProjection(Guid id)
    {
        await repository.DeleteAsync(new ProjectionId(id));
    }

    public async Task<ProjectionDto> GetProjectionById(Guid id)
    {
        Projection projection = await repository.GetByIdAsync(new ProjectionId(id));
        ProjectionDto projectionDto = projection.ProjectionToDto();
        return projectionDto;
    }

    public async Task<List<ProjectionDto>> GetProjections()
    {
        List<Projection> projections = await repository.GetAllAsync();
        List<ProjectionDto> projectionDtos = projections.Select(projection => projection.ProjectionToDto()).ToList();
        return projectionDtos;
    }

    public async Task<ProjectionDto> UpdateProjection(Guid id, ProjectionUpdateDto projectionUpdateDto)
    {
        Projection projectionToUpdate = await repository.GetByIdAsync(new ProjectionId(id));
        Projection updatedProjection = await repository.UpdateAsync(projectionToUpdate.UpdateMapper(projectionUpdateDto));
        ProjectionDto updatedProjectionDto = updatedProjection.ProjectionToDto();
        return updatedProjectionDto;
    }
}
