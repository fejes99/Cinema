using Cinema.Domain.AggregateModels.Theaters.ProjectionTypes.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters.Seats;
using Cinema.Domain.AggregateModels.Theaters.Seats.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Theaters.Theaters.Dtos;

public class TheaterDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public List<string> ProjectionTypes { get; internal set; } = new();
    public List<int> Seats { get; internal set; } = new();
}
