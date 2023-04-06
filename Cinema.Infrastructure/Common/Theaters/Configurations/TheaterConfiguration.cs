
using Cinema.Domain.AggregateModels.Theaters;
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

internal class TheaterConfiguration : IEntityTypeConfiguration<Theater>
{
    public void Configure(EntityTypeBuilder<Theater> builder)
    {
        builder.HasKey(theater => theater.Id);

        builder.Property(theater => theater.Id).HasConversion(
            theaterId => theaterId.Value,
            value => new TheaterId(value));

        builder.Property(theater => theater.Name).HasConversion(
            theaterName => theaterName.Value,
            value => new TheaterName(value));

        builder.HasMany(theater => theater.ProjectionTypes)
            .WithMany(projectionType => projectionType.Theaters)
            .UsingEntity<Dictionary<string, object>>(
                "TheaterProjectionType",
                r => r.HasOne<ProjectionType>().WithMany().HasForeignKey("ProjectionTypeId"),
                l => l.HasOne<Theater>().WithMany().HasForeignKey("TheaterId"),
                je =>
                {
                    je.HasKey("TheaterId", "ProjectionTypeId");
                    je.HasData(
                        new { TheaterId = new TheaterId(Guid.Parse("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3")), ProjectionTypeId = new ProjectionTypeId(Guid.Parse("e77354fc-8661-4a2c-80d1-d8e0557d4106")) },
                        new { TheaterId = new TheaterId(Guid.Parse("52900eaf-4ba1-40a1-aaa9-c564e532afa8")), ProjectionTypeId = new ProjectionTypeId(Guid.Parse("e77354fc-8661-4a2c-80d1-d8e0557d4106")) },
                        new { TheaterId = new TheaterId(Guid.Parse("a322aedb-053b-4507-895e-150390686b12")), ProjectionTypeId = new ProjectionTypeId(Guid.Parse("e77354fc-8661-4a2c-80d1-d8e0557d4106")) },
                        new { TheaterId = new TheaterId(Guid.Parse("a322aedb-053b-4507-895e-150390686b12")), ProjectionTypeId = new ProjectionTypeId(Guid.Parse("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2")) },
                        new { TheaterId = new TheaterId(Guid.Parse("7f251baa-0f7f-4fb4-ba9b-e807553b1335")), ProjectionTypeId = new ProjectionTypeId(Guid.Parse("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2")) },
                        new { TheaterId = new TheaterId(Guid.Parse("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb")), ProjectionTypeId = new ProjectionTypeId(Guid.Parse("faaf87a8-81d2-44e0-9dce-a2e7f48d85d2")) },
                        new { TheaterId = new TheaterId(Guid.Parse("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb")), ProjectionTypeId = new ProjectionTypeId(Guid.Parse("dfb97424-2128-4cba-854e-5ef051d2e2e6")) },
                        new { TheaterId = new TheaterId(Guid.Parse("d77c00d9-8913-4bad-83f9-5d9a054c81d1")), ProjectionTypeId = new ProjectionTypeId(Guid.Parse("dfb97424-2128-4cba-854e-5ef051d2e2e6")) });
                   
                });
    }
}
