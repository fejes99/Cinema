namespace Cinema.Domain.AggregateModels.Theaters.Seats;

public interface ISeatRepository
{
    Task<List<Seat>> GetAllAsync();
}
