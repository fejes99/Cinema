﻿using Cinema.Domain.AggregateModels.Projections.ProjectionTypes;
using Cinema.Domain.AggregateModels.Projections.ProjectionTypes.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.Infrastructure.Common.Projections.Configurations;

internal class ProjectionTypeConfiguration : IEntityTypeConfiguration<ProjectionType>
{
    public void Configure(EntityTypeBuilder<ProjectionType> builder)
    {
        builder.HasKey(projectionType => projectionType.Id);

        builder.Property(projectionType => projectionType.Id).HasConversion(
            projectionTypeId => projectionTypeId.Value,
            value => new ProjectionTypeId(value));

        builder.Property(projectionType => projectionType.Name).HasConversion(
            projectionTypeName => projectionTypeName.Value,
            value => new ProjectionTypeName(value));
    }
}
