namespace Cinema.Domain.AggregateModels.Theaters.ProjectionTypes;

public interface IProjectionTypeRepository
{
    Task<List<ProjectionType>> GetAllAsync();
}
