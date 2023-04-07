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

public class ProjectionDto
{
    public Guid Id { get; set; }
    public DateTime Time { get; set; }
    public int Price { get; set; }
    public MovieDto Movie { get; set; }
    public ProjectionTypeDto ProjectionType { get; set; }
    public TheaterDto Theater { get; set; }
    public List<TicketDto> Tickets { get; set; } = new();
}
