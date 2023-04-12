using Cinema.Domain.AggregateModels.Projections.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters.Seats.ValueObjects;
using Cinema.Domain.AggregateModels.Tickets.ValueObjects;
using Cinema.Domain.AggregateModels.Users;
using Cinema.Domain.AggregateModels.Users.ValueObjects;

namespace Cinema.Domain.AggregateModels.Tickets;

public class Ticket
{
    public TicketId Id { get; private set; }
    public TicketCreated Created { get; private set; }
    public UserId UserId { get; private set; }
    public User User { get; private set; }
    public SeatId SeatId { get; private set; }
    public ProjectionId ProjectionId { get; private set; }

    private Ticket(UserId userId, SeatId seatId, ProjectionId projectionId)
    {
        Id = new TicketId(Guid.NewGuid());
        Created = TicketCreated.Create();
        UserId = userId;
        SeatId = seatId;
        ProjectionId = projectionId;
    }

    public static Ticket Create(UserId userId, SeatId seatId, ProjectionId projectionId) 
        => new(userId, seatId, projectionId);

    public void Update(SeatId seatId)
    {
        SeatId = seatId;
    }
}
