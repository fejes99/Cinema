using Cinema.Application.Common.Movies.Dtos;
using Cinema.Application.Common.Theaters.ProjectionTypes.Dtos;
using Cinema.Application.Common.Theaters.Theaters.Dtos;
using Cinema.Application.Common.Tickets.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Projections.Dtos;

public class ProjectionCreateDto
{
    public DateTime Time { get; set; }
    public int Price { get; set; }
    public Guid MovieId { get; set; }
    public Guid ProjectionTypeId { get; set; }
    public Guid TheaterId { get; set; }
}
