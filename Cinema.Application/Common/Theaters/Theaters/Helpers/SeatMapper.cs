using Cinema.Application.Common.Theaters.Theaters.Dtos;
using Cinema.Domain.AggregateModels.Theaters.Seats;

namespace Cinema.Application.Common.Theaters.Theaters.Helpers;

public static class SeatMapper
{
    public static SeatDto SeatToDto(this Seat seat)
    {
        return new SeatDto
        {
            Id = seat.Id.Value,
            Number = seat.Number.Value
        };
    }
}
