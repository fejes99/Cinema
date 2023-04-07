using Cinema.Domain.AggregateModels.Projections.ValueObjects;

namespace Cinema.Domain.AggregateModels.Projections;

public interface IProjectionRepository
{
    Task<List<Projection>> GetAllAsync();
    Task<Projection> GetByIdAsync(ProjectionId projectionId);
    Task<Projection> CreateAsync(Projection projection);
    Task<Projection> UpdateAsync(Projection projection);
    Task DeleteAsync(ProjectionId projectionId);
    Task<bool> SaveChangesAsync();
}
