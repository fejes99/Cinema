namespace Cinema.Domain.AggregateModels.Theaters;

public interface ITheaterRepository
{
    Task<List<Theater>> GetAllAsync();
}
