namespace Cinema.Domain.AggregateModels.Projections.ProjectionTypes;

public interface IProjectionTypeRepository
{
    Task<List<ProjectionType>> GetAllAsync();
}
