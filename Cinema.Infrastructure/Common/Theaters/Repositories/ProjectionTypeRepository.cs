using Cinema.Domain.AggregateModels.Theaters.ProjectionTypes;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Infrastructure.Common.Theaters.Repositories;

public class ProjectionTypeRepository : IProjectionTypeRepository
{
    private readonly DatabaseContext context;

    public ProjectionTypeRepository(DatabaseContext context)
    {
        this.context = context;
    }

    public async Task<List<ProjectionType>> GetAllAsync()
    {
        return await context.ProjectionTypes.ToListAsync();
    }
}
