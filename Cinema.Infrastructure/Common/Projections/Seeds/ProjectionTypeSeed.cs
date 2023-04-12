
using Cinema.Domain.AggregateModels.Projections.ProjectionTypes;
using Cinema.Domain.AggregateModels.Projections.ProjectionTypes.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.Infrastructure.Common.Projections.Seeds
{
    internal class ProjectionTypeSeed : IEntityTypeConfiguration<ProjectionType>
    {
        public void Configure(EntityTypeBuilder<ProjectionType> builder)
        {
            builder.HasData(
                ProjectionType.Seed(new ProjectionTypeId(Guid.Parse("e77354fc-8661-4a2c-80d1-d8e0557d4106")), new ProjectionTypeName("2D")),
                ProjectionType.Seed(new ProjectionTypeId(Guid.Parse("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2")), new ProjectionTypeName("3D")),
                ProjectionType.Seed(new ProjectionTypeId(Guid.Parse("dfb97424-2128-4cba-854e-5ef051d2e2e6")), new ProjectionTypeName("4D")));
        }
    }
}
