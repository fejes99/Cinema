using Cinema.Domain.AggregateModels.Theaters.Seats;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        return await context.Seats.ToListAsync();
    }
}
