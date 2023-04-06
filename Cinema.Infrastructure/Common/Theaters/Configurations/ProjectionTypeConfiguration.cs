using Cinema.Domain.AggregateModels.Theaters.ProjectionTypes;
using Cinema.Domain.AggregateModels.Theaters.ProjectionTypes.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Common.Theaters.Configurations;

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
