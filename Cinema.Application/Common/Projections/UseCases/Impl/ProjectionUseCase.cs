using Cinema.Application.Common.Projections.Dtos;
using Cinema.Application.Common.Projections.Exceptions;
using Cinema.Application.Common.Projections.Helpers;
using Cinema.Domain.AggregateModels.Movies;
using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using Cinema.Domain.AggregateModels.Projections;
using Cinema.Domain.AggregateModels.Projections.ProjectionTypes.ValueObjects;
using Cinema.Domain.AggregateModels.Projections.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters;
using Cinema.Domain.AggregateModels.Theaters.ValueObjects;

namespace Cinema.Application.Common.Projections.UseCases.Impl;

public class ProjectionUseCase : IProjectionUseCase
{
    private readonly IProjectionRepository repository;
    private readonly ITheaterRepository theaterRepository;
    private readonly IMovieRepository movieRepository;

    public ProjectionUseCase(IProjectionRepository repository, ITheaterRepository theaterRepository, IMovieRepository movieRepository)
    {
        this.repository = repository;
        this.theaterRepository = theaterRepository;
        this.movieRepository = movieRepository;
    }

    public async Task<ProjectionCreateDto> CreateProjection(ProjectionCreateDto projectionCreateDto)
    {
        Theater theater = await theaterRepository.GetByIdAsync(new TheaterId(projectionCreateDto.TheaterId));
        Movie movie = await movieRepository.GetByIdAsync(new MovieId(projectionCreateDto.MovieId));
        Projection projectionToCreate = Projection.Create(ProjectionTime.Create(projectionCreateDto.Time),ProjectionPrice.Create(projectionCreateDto.Price), movie, new ProjectionTypeId(projectionCreateDto.ProjectionTypeId), theater);

        await repository.CreateAsync(projectionToCreate);
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

    public async Task<List<ProjectionDetailsDto>> GetProjections()
    {
        List<Projection> projections = await repository.GetAllAsync();
        List<ProjectionDetailsDto> projectionDtos = projections.Select(projection => projection.ProjectionToDetailsDto()).ToList();
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
