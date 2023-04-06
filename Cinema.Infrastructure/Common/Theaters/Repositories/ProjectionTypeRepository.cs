using Cinema.Domain.AggregateModels.Theaters.ProjectionTypes;
using Cinema.Domain.AggregateModels.Theaters.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
