namespace Cinema.Domain.AggregateModels.Tickets.ValueObjects;

public record TicketCreated
{
    public DateTime Value { get; init; }

    private TicketCreated(DateTime value) => Value = value;

    public static TicketCreated Create() => new(DateTime.Now);
    public static TicketCreated CreateWithValue(DateTime value) => new(value);

    public override string ToString() => Value.ToString("ss:mm:hh dd/MM/yyyy");
}
