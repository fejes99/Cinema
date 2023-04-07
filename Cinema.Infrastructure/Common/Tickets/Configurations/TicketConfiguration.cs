using Cinema.Domain.AggregateModels.Projections.ValueObjects;
using Cinema.Domain.AggregateModels.Theaters.Seats.ValueObjects;
using Cinema.Domain.AggregateModels.Tickets;
using Cinema.Domain.AggregateModels.Tickets.ValueObjects;
using Cinema.Domain.AggregateModels.Users.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinema.Infrastructure.Common.Tickets.Configurations;

internal class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.HasKey(ticket => ticket.Id);

        builder.Property(ticket => ticket.Id).HasConversion(
            ticketId => ticketId.Value,
            value => new TicketId(value));

        builder.Property(ticket => ticket.Created).HasConversion(
            ticketCreated => ticketCreated.Value,
            value => TicketCreated.CreateWithValue(value));

        builder.Property(ticket => ticket.UserId).HasConversion(
            ticketUserId => ticketUserId.Value,
            value => new UserId(value));

        builder.Property(ticket => ticket.SeatId).HasConversion(
            ticketSeatId => ticketSeatId.Value,
            value => new SeatId(value));

        builder.Property(ticket => ticket.ProjectionId).HasConversion(
            ticketProjectionId => ticketProjectionId.Value,
            value => new ProjectionId(value));
    }
}
