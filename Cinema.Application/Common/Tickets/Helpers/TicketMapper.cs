using Cinema.Application.Common.Tickets.Dtos;
using Cinema.Domain.AggregateModels.Projections.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters.Seats.ValueObjects;
using Cinema.Domain.AggregateModels.Tickets;
using Cinema.Domain.AggregateModels.Users.ValueObjects;

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
            SeatId = ticket.SeatId.Value
        };
    }

    public static Ticket CreateDtoToTicket(this TicketCreateDto ticketCreateDto)
    {
        UserId userId = new UserId(ticketCreateDto.UserId);
        SeatId seatId = new SeatId(ticketCreateDto.SeatId);
        ProjectionId projectionId = new ProjectionId(ticketCreateDto.ProjectionId);

        return Ticket.Create(userId, seatId, projectionId);
    }

    public static Ticket UpdateMapper(this Ticket ticket, TicketUpdateDto ticketUpdateDto)
    {
        ticket.Update(new SeatId(ticketUpdateDto.SeatId));
        return ticket;
    }
}
