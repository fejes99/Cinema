using Cinema.Domain.AggregateModels.Theaters.Seats;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Infrastructure.Common.Theaters.Repositories;

public class SeatRepository : ISeatRepository
{
    private readonly DatabaseContext context;

    public SeatRepository(DatabaseContext context)
    {
        this.context = context;
    }

    public async Task<List<Seat>> GetAllAsync()
    {
        return await context.Seats
            .OrderBy(seat => seat.Number)
            .ToListAsync();
    }
}
