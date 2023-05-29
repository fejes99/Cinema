namespace Cinema.Application.Common.Projections.Dtos;

public class ProjectionCreateDto
{
    public DateTime Time { get; set; }
    public int Price { get; set; }
    public Guid MovieId { get; set; }
    public Guid ProjectionTypeId { get; set; }
    public Guid TheaterId { get; set; }
}
