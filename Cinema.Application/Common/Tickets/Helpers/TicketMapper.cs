using Cinema.Application.Common.Projections.Helpers;
using Cinema.Application.Common.Theaters.Helpers;
using Cinema.Application.Common.Tickets.Dtos;
using Cinema.Application.Common.Users.Helpers;
using Cinema.Domain.AggregateModels.Theaters.Seats.ValueObjects;
using Cinema.Domain.AggregateModels.Tickets;

namespace Cinema.Application.Common.Tickets.Helpers;

public static class TicketMapper
{
    public static TicketDto TicketToDto(this Ticket ticket)
    {
        return new TicketDto
        {
            Id = ticket.Id.Value,
            Created = ticket.Created.Value,
            UserId = ticket.UserId.Value,
            SeatId = ticket.SeatId.Value,
            ProjectionId = ticket.ProjectionId.Value,
        };
    }

    public static TicketDetailsDto TicketToDetailsDto(this Ticket ticket)
    {
        return new TicketDetailsDto
        {
            Id = ticket.Id.Value,
            Created = ticket.Created.Value,
            User = ticket.User.UserToDto(),
            Seat = ticket.Seat.SeatToDto(),
            Projection = ticket.Projection.ProjectionToDto()
        };
    }

    public static ProjectionTicketDto TicketToProjectionTicketDto(this Ticket ticket)
    {
        return new ProjectionTicketDto
        {
            Id = ticket.Id.Value,
            Created = ticket.Created.Value,
            User = ticket.User.UserToProjectionUserDto()

        };
    }

    public static Ticket UpdateMapper(this Ticket ticket, TicketUpdateDto ticketUpdateDto)
    {
        ticket.Update(new SeatId(ticketUpdateDto.SeatId));
        return ticket;
    }
}
