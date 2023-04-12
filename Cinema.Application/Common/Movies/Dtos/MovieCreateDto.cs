namespace Cinema.Application.Common.Movies.Dtos;

public class MovieCreateDto
{
    public string Name { get; set; } = string.Empty;
    public string? Director { get; set; }
    public int Duration { get; set; }
    public string Distributor { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public int Year { get; set; }
    public string TrailerUrl { get; set; } = string.Empty;
    public string? Description { get; set; }
}

