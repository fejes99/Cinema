namespace Cinema.Application.Common.Theaters.Theaters.Dtos;

public class TheaterDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public List<string> ProjectionTypes { get; internal set; } = new();
    public List<SeatDto> Seats { get; internal set; } = new();
}
