using Cinema.Application.Common.Users.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Tickets.Dtos;

public class ProjectionTicketDto
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public ProjectionUserDto User { get; set; }
}
