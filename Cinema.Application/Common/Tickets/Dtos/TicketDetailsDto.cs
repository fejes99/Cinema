using Cinema.Application.Common.Projections.Dtos;
using Cinema.Application.Common.Theaters.Dtos;
using Cinema.Application.Common.Users.Dtos;

namespace Cinema.Application.Common.Tickets.Dtos;

public class TicketDetailsDto
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public UserDto User { get; set; }
    public SeatDto Seat { get; set; }
    public ProjectionDto Projection { get; set; }
}
