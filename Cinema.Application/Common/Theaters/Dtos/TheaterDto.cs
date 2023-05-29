using Cinema.Application.Common.Projections.ProjectionTypes.Dtos;

namespace Cinema.Application.Common.Theaters.Dtos;

public class TheaterDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<ProjectionTypeDto>? ProjectionTypes { get; internal set; } = new();
    public List<SeatDto>? Seats { get; internal set; } = new();
}
