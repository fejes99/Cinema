using Cinema.Domain.AggregateModels.Theaters;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Infrastructure.Common.Theaters.Repositories;

public class TheaterRepository : ITheaterRepository
{
    private readonly DatabaseContext context;

    public TheaterRepository(DatabaseContext context)
    {
        this.context = context;
    }

    public async Task<List<Theater>> GetAllAsync()
    {
        return await context.Theaters
            .Include(theater => theater.ProjectionTypes)
            .Include(theater => theater.Seats)
            .ToListAsync();
    }
}
