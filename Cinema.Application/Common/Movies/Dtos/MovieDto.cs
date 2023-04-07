namespace Cinema.Application.Common.Movies.Dtos;

public class MovieDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string? Director { get; set; }
    public int Duration { get; set; }
    public string Distributor { get; set; } = String.Empty;
    public string Country { get; set; } = String.Empty;
    public int Year { get; set; }
    public string? Description { get; set; }
}
