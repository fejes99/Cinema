using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Movies.Dtos;

public class ProjectionMovieDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Director { get; set; }
    public int Duration { get; set; } = int.MaxValue;
    public string Distributor { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public int Year { get; set; }
}
