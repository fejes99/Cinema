using Cinema.Application.Common.Theaters.ProjectionTypes.Dtos;
using Cinema.Domain.AggregateModels.Theaters.ProjectionTypes;

namespace Cinema.Application.Common.Theaters.ProjectionTypes.Helpers;

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
