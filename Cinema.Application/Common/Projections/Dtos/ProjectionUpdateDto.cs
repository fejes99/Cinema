using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Projections.Dtos;

public class ProjectionUpdateDto
{
    public DateTime Time { get; set; }
    public int Price { get; set; }
    public Guid ProjectionTypeId { get; set; }
    public Guid TheaterId { get; set; }
}
