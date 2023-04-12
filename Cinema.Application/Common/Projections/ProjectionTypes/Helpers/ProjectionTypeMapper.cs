using Cinema.Application.Common.Projections.ProjectionTypes.Dtos;
using Cinema.Domain.AggregateModels.Projections.ProjectionTypes;

namespace Cinema.Application.Common.Projections.ProjectionTypes.Helpers;

public static class ProjectionTypeMapper
{
    public static ProjectionTypeDto ProjectionTypeToDto(this ProjectionType projectionType)
    {
        return new ProjectionTypeDto
        {
            Id = projectionType.Id.Value,
            Name = projectionType.Name.Value
        };
    }
}
