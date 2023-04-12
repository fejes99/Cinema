using Cinema.Domain.AggregateModels.Tickets;
using Cinema.Domain.AggregateModels.Tickets.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Infrastructure.Common.Tickets.Repositories;

public class TicketRepository : ITicketRepository
{
    private readonly DatabaseContext context;

    public TicketRepository(DatabaseContext context)
    {
        this.context = context;
    }

    public async Task<Ticket> CreateAsync(Ticket ticket)
    {
        await context.AddAsync(ticket);
        await SaveChangesAsync();
        return ticket;
    }

    public async Task DeleteAsync(TicketId ticketId)
    {
        Ticket ticketToDelete = await GetByIdAsync(ticketId);
        context.Remove(ticketToDelete);
        await SaveChangesAsync();
    }

    public async Task<List<Ticket>> GetAllAsync()
    {
        return await context.Tickets.ToListAsync();
    }

    public async Task<Ticket> GetByIdAsync(TicketId ticketId)
    {
        var ticket = await context.Tickets
            .Include(ticket => ticket.User)
            .FirstOrDefaultAsync(ticket => ticket.Id == ticketId);
        return ticket!;
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<Ticket> UpdateAsync(Ticket ticket)
    {
        context.Update(ticket);
        await SaveChangesAsync();
        return ticket;
    }
}
