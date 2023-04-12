using Cinema.Application.Common.Tickets.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Movies.Dtos;

public class MovieProjectionDto
{
    public Guid Id { get; set; }
    public DateTime Time { get; set; }
    public int Price { get; set; }
    public string ProjectionType { get; set; } = string.Empty;
    public string Theater { get; set; } = string.Empty;
    public bool IsSold { get; set; }
}
