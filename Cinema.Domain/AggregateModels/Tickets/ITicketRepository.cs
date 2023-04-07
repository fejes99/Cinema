using Cinema.Domain.AggregateModels.Tickets.ValueObjects;

namespace Cinema.Domain.AggregateModels.Tickets;

public interface ITicketRepository
{
    Task<List<Ticket>> GetAllAsync();
    Task<Ticket> GetByIdAsync(TicketId ticketId);
    Task<Ticket> CreateAsync(Ticket ticket);
    Task<Ticket> UpdateAsync(Ticket ticket);
    Task DeleteAsync(TicketId ticketId);
    Task<bool> SaveChangesAsync();
}
