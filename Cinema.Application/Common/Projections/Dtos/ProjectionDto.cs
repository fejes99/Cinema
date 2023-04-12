using Cinema.Application.Common.Movies.Dtos;
using Cinema.Application.Common.Projections.ProjectionTypes.Dtos;
using Cinema.Application.Common.Theaters.Dtos;
using Cinema.Application.Common.Tickets.Dtos;

namespace Cinema.Application.Common.Projections.Dtos;

public class ProjectionDto
{
    public Guid Id { get; set; }
    public DateTime Time { get; set; }
    public int Price { get; set; }
    public ProjectionMovieDto Movie { get; set; }
    public string ProjectionType { get; set; } = string.Empty;
    public string Theater { get; set; } = string.Empty;
    public bool IsSold { get; set; }
}
