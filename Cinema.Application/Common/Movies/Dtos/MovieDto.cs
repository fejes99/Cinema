using Cinema.Application.Common.Projections.Dtos;
using Cinema.Application.Common.Theaters.Dtos;

namespace Cinema.Application.Common.Movies.Dtos;

public class MovieDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Director { get; set; }
    public int Duration { get; set; } = int.MaxValue;
    public string Distributor { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public int Year { get; set; }
    public string TrailerUrl { get; set; } = string.Empty;
    public string? Description { get; set; }
    public List<MovieProjectionDto> Projections { get; internal set; } = new();
}
