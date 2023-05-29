using Cinema.Application.Common.Users.Dtos;

namespace Cinema.Application.Common.Tickets.Dtos;

public class ProjectionTicketDto
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public ProjectionUserDto User { get; set; }
}
