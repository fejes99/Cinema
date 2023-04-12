using Cinema.Domain.AggregateModels.Projections.ProjectionTypes.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters;

namespace Cinema.Domain.AggregateModels.Projections.ProjectionTypes;

public class ProjectionType
{
    public ProjectionTypeId Id { get; private set; }
    public ProjectionTypeName Name { get; private set; }
    public List<Theater> Theaters { get; private set; } = new();
    public List<Projection> Projections { get; private set; } = new();

    public ProjectionType(ProjectionTypeId id, ProjectionTypeName name)
    {
        Id = id;
        Name = name;
    }
    public static ProjectionType Seed(ProjectionTypeId id, ProjectionTypeName name) => new(id, name);
}
