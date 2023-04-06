using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Theaters.ProjectionTypes.Dtos;

public class ProjectionTypeDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = String.Empty;
}
