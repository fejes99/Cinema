using Cinema.Application.Common.Movies.Dtos;
using Cinema.Application.Common.Movies.Helpers;
using Cinema.Application.Common.Projections.Dtos;
using Cinema.Application.Common.Projections.ProjectionTypes.Helpers;
using Cinema.Application.Common.Theaters.Helpers;
using Cinema.Application.Common.Tickets.Helpers;
using Cinema.Domain.AggregateModels.Projections;
using Cinema.Domain.AggregateModels.Projections.ProjectionTypes.ValueObjects;
using Cinema.Domain.AggregateModels.Projections.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters.ValueObjects;

namespace Cinema.Application.Common.Projections.Helpers;

public static class ProjectionMapper
{
    public static ProjectionDto ProjectionToDto(this Projection projection)
    {
        return new ProjectionDto
        {
            Id = projection.Id.Value,
            Time = projection.Time.Value,
            Price = projection.Price.Value,
            Movie = projection.Movie.MovieToProjectionMovieDto(),
            ProjectionType = projection.ProjectionType.ProjectionTypeToDto(),
            Theater = projection.Theater.TheaterToDto(),
            IsSold = projection.IsSold
        };
    }

    public static ProjectionDetailsDto ProjectionToDetailsDto(this Projection projection)
    {
        return new ProjectionDetailsDto
        {
            Id = projection.Id.Value,
            Time = projection.Time.Value,
            Price = projection.Price.Value,
            Movie = projection.Movie.MovieToProjectionMovieDto(),
            ProjectionType = projection.ProjectionType.ProjectionTypeToDto(),
            Theater = projection.Theater.TheaterToDto(),
            IsSold = projection.IsSold,
            Tickets = projection.Tickets.Select(ticket => ticket.TicketToProjectionTicketDto()).ToList()
        };
    }

    public static MovieProjectionDto ProjectionToMovieProjectionDto(this Projection projection)
    {
        return new MovieProjectionDto
        {
            Id = projection.Id.Value,
            Time = projection.Time.Value,
            Price = projection.Price.Value,
            ProjectionType = projection.ProjectionType.Name.Value,
            Theater = projection.Theater.Name.Value,
            IsSold = projection.IsSold
        };
    }

    public static Projection UpdateMapper(this Projection projection, ProjectionUpdateDto projectionUpdateDto)
    {
        ProjectionTime? time = null;
        ProjectionPrice? price = null;
        ProjectionTypeId? projectionTypeId = null;
        TheaterId? theaterId = null;

        if (projectionUpdateDto.Time != default) time = ProjectionTime.Create(projectionUpdateDto.Time);
        if (projectionUpdateDto.Price != default) price = ProjectionPrice.Create(projectionUpdateDto.Price);
        if (projectionUpdateDto.ProjectionTypeId != Guid.Empty) projectionTypeId = new ProjectionTypeId(projectionUpdateDto.ProjectionTypeId);
        if (projectionUpdateDto.TheaterId != Guid.Empty) theaterId = new TheaterId(projectionUpdateDto.TheaterId);

        projection.Update(time, price, projectionTypeId, theaterId);
        return projection;
    }
}
