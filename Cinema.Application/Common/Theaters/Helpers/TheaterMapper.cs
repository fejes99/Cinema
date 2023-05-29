using Cinema.Application.Common.Projections.ProjectionTypes.Helpers;
using Cinema.Application.Common.Theaters.Dtos;
using Cinema.Domain.AggregateModels.Theaters;

namespace Cinema.Application.Common.Theaters.Helpers;

public static class TheaterMapper
{
    public static TheaterDto TheaterToDto(this Theater theater)
    {
        return new TheaterDto
        {
            Id = theater.Id.Value,
            Name = theater.Name.Value,
            ProjectionTypes = theater.ProjectionTypes.Select(projectionType => projectionType.ProjectionTypeToDto()).ToList(),
            Seats = theater.Seats.Select(seat => seat.SeatToDto()).ToList()
        };
    }
}
