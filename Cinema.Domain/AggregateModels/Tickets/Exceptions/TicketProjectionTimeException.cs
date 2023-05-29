using Cinema.Domain.Abstractions;

namespace Cinema.Domain.AggregateModels.Tickets.Exceptions;

internal class TicketProjectionTimeException : DomainException
{
    public TicketProjectionTimeException(string message) : base(message)
    {
    }
}
