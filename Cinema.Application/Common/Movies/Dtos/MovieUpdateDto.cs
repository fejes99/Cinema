namespace Cinema.Application.Common.Movies.Dtos;

public class MovieUpdateDto
{
    public string? Name { get; set; }
    public string? Director { get; set; }
    public int? Duration { get; set; }
    public string? Distributor { get; set; }
    public string? Country { get; set; }
    public int? Year { get; set; }
    public string? TrailerUrl { get; set; }
    public string? Description { get; set; }
}
