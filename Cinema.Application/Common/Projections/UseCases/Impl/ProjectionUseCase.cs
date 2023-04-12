using Cinema.Application.Common.Projections.Dtos;
using Cinema.Application.Common.Projections.Exceptions;
using Cinema.Application.Common.Projections.Helpers;
using Cinema.Domain.AggregateModels.Movies;
using Cinema.Domain.AggregateModels.Projections;
using Cinema.Domain.AggregateModels.Projections.ValueObjects;

namespace Cinema.Application.Common.Projections.UseCases.Impl;

public class ProjectionUseCase : IProjectionUseCase
{
    private readonly IProjectionRepository repository;

    public ProjectionUseCase(IProjectionRepository repository, IMovieRepository movieRepository)
    {
        this.repository = repository;
    }

    public async Task<ProjectionCreateDto> CreateProjection(ProjectionCreateDto projectionCreateDto)
    {
        await repository.CreateAsync(projectionCreateDto.CreateDtoToProjection());
        return projectionCreateDto;
    }

    public async Task DeleteProjection(Guid id)
    {
        Projection projection = await repository.GetByIdAsync(new ProjectionId(id));
        if (projection == null) throw new ProjectionNotFoundException("Projection not found.");
        projection.Delete();

        if (projection.IsDeleted)
        {
            await repository.UpdateAsync(projection);
        } 
        else
        {
            await repository.DeleteAsync(projection);
        }
    }

    public async Task<ProjectionDetailsDto> GetProjectionById(Guid id)
    {
        Projection projection = await repository.GetByIdAsync(new ProjectionId(id));
        ProjectionDetailsDto projectionDto = projection.ProjectionToDetailsDto();
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
