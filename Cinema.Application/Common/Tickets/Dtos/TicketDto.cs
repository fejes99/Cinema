namespace Cinema.Application.Common.Tickets.Dtos;

public class TicketDto
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public Guid UserId { get; set; }
    public Guid SeatId { get; set; }
    public Guid ProjectionId { get; set; }
}
