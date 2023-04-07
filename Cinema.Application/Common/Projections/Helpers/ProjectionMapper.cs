using Cinema.Application.Common.Movies.Helpers;
using Cinema.Application.Common.Projections.Dtos;
using Cinema.Application.Common.Theaters.ProjectionTypes.Helpers;
using Cinema.Application.Common.Theaters.Theaters.Helpers;
using Cinema.Application.Common.Tickets.Helpers;
using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using Cinema.Domain.AggregateModels.Projections;
using Cinema.Domain.AggregateModels.Projections.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters;
using Cinema.Domain.AggregateModels.Theaters.ProjectionTypes;
using Cinema.Domain.AggregateModels.Theaters.ProjectionTypes.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Movie = projection.Movie.MovieToDto(),
            ProjectionType = projection.ProjectionType.ProjectionTypeToDto(),
            Theater = projection.Theater.TheaterToDto(),
            Tickets = projection.Tickets.Select(ticket => ticket.TicketToDto()).ToList()
        };
    }

    public static Projection CreateDtoToProjection(this ProjectionCreateDto projectionCreateDto)
    {
        ProjectionTime time = ProjectionTime.CreateWithValue(projectionCreateDto.Time);
        ProjectionPrice price = ProjectionPrice.Create(projectionCreateDto.Price);
        MovieId movieId = new MovieId(projectionCreateDto.MovieId);
        ProjectionTypeId projectionTypeId = new ProjectionTypeId(projectionCreateDto.ProjectionTypeId);
        TheaterId theaterId = new TheaterId(projectionCreateDto.TheaterId);

        return Projection.Create(time, price, movieId, projectionTypeId, theaterId);
    }

    public static Projection UpdateMapper(this Projection projection, ProjectionUpdateDto projectionUpdateDto)
    {
        ProjectionTime? time = null;
        ProjectionPrice? price = null;
        ProjectionTypeId? projectionTypeId = null;
        TheaterId? theaterId = null;

        if (projectionUpdateDto.Time != default) time = ProjectionTime.CreateWithValue(projectionUpdateDto.Time);
        if (projectionUpdateDto.Price != default) price = ProjectionPrice.Create(projectionUpdateDto.Price);
        if (projectionUpdateDto.ProjectionTypeId != Guid.Empty) projectionTypeId = new ProjectionTypeId(projectionUpdateDto.ProjectionTypeId);
        if (projectionUpdateDto.TheaterId != Guid.Empty) theaterId = new TheaterId(projectionUpdateDto.TheaterId);

        projection.Update(time, price, projectionTypeId, theaterId);
        return projection;
    }
}
