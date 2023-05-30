using Cinema.Domain.AggregateModels.Projections;
using Cinema.Domain.AggregateModels.Projections.ValueObjects;
using Cinema.Infrastructure.Common.Helper;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Infrastructure.Common.Projections.Repositories;

public class ProjectionRepository : IProjectionRepository
{
    private readonly DatabaseContext context;

    public ProjectionRepository(DatabaseContext context)
    {
        this.context = context;
    }

    public async Task<Projection> CreateAsync(Projection projection)
    {
        await context.AddAsync(projection);
        await SaveChangesAsync();
        return projection;
    }

    public async Task DeleteAsync(Projection projection)
    {
        context.Remove(projection);
        await SaveChangesAsync();
    }

    public async Task<List<Projection>> GetAllAsync()
    {
        return await context.Projections
            .Include(projection => projection.Movie)
            .Include(projection => projection.ProjectionType)
            .Include(projection => projection.Theater).ThenInclude(theater => theater.Seats)
            .Include(projection => projection.Theater).ThenInclude(theater => theater.ProjectionTypes.OrderBy(projectionType => projectionType.Name))
            .Include(projection => projection.Tickets).ThenInclude(ticket => ticket.User)
            .Include(projection => projection.Tickets).ThenInclude(ticket => ticket.Seat)
            .OrderBy(projection => projection.Time)
            .ToListAsync();
    }

    public async Task<Projection> GetByIdAsync(ProjectionId projectionId)
    {
        var projection = await context.Projections
            .Include(projection => projection.Movie)
            .Include(projection => projection.ProjectionType)
            .Include(projection => projection.Theater).ThenInclude(theater => theater.Seats.OrderBy(seat => seat.Number))
            .Include(projection => projection.Theater).ThenInclude(theater => theater.ProjectionTypes.OrderBy(projectionType => projectionType.Name))
            .Include(projection => projection.Tickets).ThenInclude(ticket => ticket.User)
            .Include(projection => projection.Tickets.OrderBy(ticket => ticket.Seat.Number)).ThenInclude(ticket => ticket.Seat)
            .FirstOrDefaultAsync(projection => projection.Id == projectionId);
        return projection!;
    }



    public async Task<bool> SaveChangesAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<Projection> UpdateAsync(Projection projection)
    {
        context.Update(projection);
        await SaveChangesAsync();
        var updatedProjetion = await GetByIdAsync(projection.Id);
        return updatedProjetion!;
    }
}
