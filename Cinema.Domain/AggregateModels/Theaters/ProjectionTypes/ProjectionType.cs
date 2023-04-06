using Cinema.Domain.AggregateModels.Theaters.ProjectionTypes.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Theaters.ProjectionTypes;

public class ProjectionType
{
    public ProjectionTypeId Id { get; private set; }
    public ProjectionTypeName Name { get; private set; }
    public List<Theater> Theaters { get; private set; } = new();

    public ProjectionType(ProjectionTypeId id, ProjectionTypeName name)
    {
        Id = id;
        Name = name;
    }
    public static ProjectionType Seed(ProjectionTypeId id, ProjectionTypeName name) => new(id, name);
}
