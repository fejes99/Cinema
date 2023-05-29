using Cinema.Domain.AggregateModels.Theaters.ValueObjects;

namespace Cinema.Domain.AggregateModels.Theaters;

public interface ITheaterRepository
{
    Task<List<Theater>> GetAllAsync();
    Task<Theater> GetByIdAsync(TheaterId theaterId);
}
