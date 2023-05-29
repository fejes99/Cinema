using Cinema.Domain.AggregateModels.Projections;
using Cinema.Domain.AggregateModels.Projections.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters.Seats;
using Cinema.Domain.AggregateModels.Theaters.Seats.ValueObjects;
using Cinema.Domain.AggregateModels.Tickets.Exceptions;
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
    public Seat Seat { get; private set; }
    public ProjectionId ProjectionId { get; private set; }
    public Projection Projection { get; private set; }

    private Ticket(UserId userId, SeatId seatId, ProjectionId projectionId)
    {
        Id = new TicketId(Guid.NewGuid());
        Created = TicketCreated.Create();
        UserId = userId;
        SeatId = seatId;
        ProjectionId = projectionId;
    }

    public static Ticket CreateForProjection(UserId userId, SeatId seatId, Projection projection)
    {
        if (!projection.CanSellTickets())
        {
            throw new TicketProjectionTimeException("Projection is not valid for selling tickets.");
        }

        return new (userId, seatId, projection.Id);
    }


    public void Update(SeatId seatId)
    {
        SeatId = seatId;
    }
}
