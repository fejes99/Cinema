using Cinema.Domain.AggregateModels.Theaters;
using Cinema.Domain.AggregateModels.Theaters.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.Infrastructure.Common.Theaters.Seeds
{
    internal class TheaterSeed : IEntityTypeConfiguration<Theater>
    {
        public void Configure(EntityTypeBuilder<Theater> builder)
        {
            builder.HasData(
                Theater.Seed(new TheaterId(Guid.Parse("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3")), new TheaterName("Sala 1")),
                Theater.Seed(new TheaterId(Guid.Parse("52900eaf-4ba1-40a1-aaa9-c564e532afa8")), new TheaterName("Sala 2")),
                Theater.Seed(new TheaterId(Guid.Parse("a322aedb-053b-4507-895e-150390686b12")), new TheaterName("Sala 3")),
                Theater.Seed(new TheaterId(Guid.Parse("7f251baa-0f7f-4fb4-ba9b-e807553b1335")), new TheaterName("Sala 4")),
                Theater.Seed(new TheaterId(Guid.Parse("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb")), new TheaterName("Sala 5")),
                Theater.Seed(new TheaterId(Guid.Parse("d77c00d9-8913-4bad-83f9-5d9a054c81d1")), new TheaterName("Sala 6"))
            );
        }
    }
}
