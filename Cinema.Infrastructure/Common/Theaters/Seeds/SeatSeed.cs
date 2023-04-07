using Cinema.Domain.AggregateModels.Theaters.Seats;
using Cinema.Domain.AggregateModels.Theaters.Seats.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.Infrastructure.Common.Theaters.Seeds;

internal class SeatSeed : IEntityTypeConfiguration<Seat>
{
    public void Configure(EntityTypeBuilder<Seat> builder)
    {
        var seats = new List<Seat>();
        seats.AddRange(
            Enumerable.Range(1, 4).Select(i => 
            Seat.Seed(new SeatId(Guid.NewGuid()), new SeatNumber(i), new TheaterId(Guid.Parse("f1cbab66-97ab-4cbe-a2ec-b4d84dde9bb3")))
            ));
        seats.AddRange(
            Enumerable.Range(1, 10).Select(i =>
            Seat.Seed(new SeatId(Guid.NewGuid()), new SeatNumber(i), new TheaterId(Guid.Parse("52900eaf-4ba1-40a1-aaa9-c564e532afa8")))
            ));
        seats.AddRange(
            Enumerable.Range(1, 20).Select(i =>
            Seat.Seed(new SeatId(Guid.NewGuid()), new SeatNumber(i), new TheaterId(Guid.Parse("a322aedb-053b-4507-895e-150390686b12")))
            ));
        seats.AddRange(
            Enumerable.Range(1, 15).Select(i =>
            Seat.Seed(new SeatId(Guid.NewGuid()), new SeatNumber(i), new TheaterId(Guid.Parse("7f251baa-0f7f-4fb4-ba9b-e807553b1335")))
            ));
        seats.AddRange(
            Enumerable.Range(1, 15).Select(i =>
            Seat.Seed(new SeatId(Guid.NewGuid()), new SeatNumber(i), new TheaterId(Guid.Parse("7c7029a8-dbf9-4fa0-ad1e-b67f65be85eb")))
            ));
        seats.AddRange(
            Enumerable.Range(1, 10).Select(i =>
            Seat.Seed(new SeatId(Guid.NewGuid()), new SeatNumber(i), new TheaterId(Guid.Parse("d77c00d9-8913-4bad-83f9-5d9a054c81d1")))
            ));



        builder.HasData(seats);
    }
}
