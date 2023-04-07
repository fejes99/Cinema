namespace Cinema.Application.Common.Tickets.Dtos;

public class TicketCreateDto
{
    public Guid UserId { get; set; }
    public Guid SeatId { get; set; }
    public Guid ProjectionId { get; set; }
}
