using Cinema.Domain.AggregateModels.Theaters.Seats;
using Cinema.Domain.AggregateModels.Theaters.Seats.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Common.Theaters.Configurations;

internal class SeatConfiguration : IEntityTypeConfiguration<Seat>
{
    public void Configure(EntityTypeBuilder<Seat> builder)
    {
        builder.HasKey(seat => seat.Id);

        builder.Property(seat => seat.Id).HasConversion(
            seatId => seatId.Value,
            value => new SeatId(value));

        builder.Property(seat => seat.Number).HasConversion(
            seatNumber => seatNumber.Value,
            value => new SeatNumber(value));

        builder.Property(seat => seat.TheaterId).HasConversion(
            seatTheaterId => seatTheaterId.Value,
            value => new TheaterId(value));
    }
}
