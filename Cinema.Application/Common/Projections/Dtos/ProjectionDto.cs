using Cinema.Application.Common.Movies.Dtos;
using Cinema.Application.Common.Projections.ProjectionTypes.Dtos;
using Cinema.Application.Common.Theaters.Dtos;

namespace Cinema.Application.Common.Projections.Dtos;

public class ProjectionDto
{
    public Guid Id { get; set; }
    public DateTime Time { get; set; }
    public int Price { get; set; }
    public ProjectionMovieDto Movie { get; set; }
    public ProjectionTypeDto ProjectionType { get; set; }
    public TheaterDto Theater { get; set; }
    public bool IsSold { get; set; }
}
