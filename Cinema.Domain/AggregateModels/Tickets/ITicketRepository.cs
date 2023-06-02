using Cinema.Domain.AggregateModels.Tickets.ValueObjects;
using Cinema.Domain.AggregateModels.Users.ValueObjects;

namespace Cinema.Domain.AggregateModels.Tickets;

public interface ITicketRepository
{
    Task<List<Ticket>> GetAllAsync();
    Task<List<Ticket>> GetAllByUserIdAsync(UserId userId);
    Task<Ticket> GetByIdAsync(TicketId ticketId);
    Task<Ticket> CreateAsync(Ticket ticket);
    Task<Ticket> UpdateAsync(Ticket ticket);
    Task DeleteAsync(TicketId ticketId);
    Task<bool> SaveChangesAsync();
}
