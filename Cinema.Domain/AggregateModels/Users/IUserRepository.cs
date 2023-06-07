using Cinema.Domain.AggregateModels.Users.ValueObjects;

namespace Cinema.Domain.AggregateModels.Users;

public interface IUserRepository
{
    Task<List<User>> GetAllAsync();
    Task<User> GetByIdAsync(UserId userId);
    Task<User> GetByUsernameAsync(string username);
    Task<User> GetByEmailAsync(string email);
    Task<User> CreateAsync(User user);
    Task<User> UpdateAsync(User user);
    Task DeleteAsync(UserId userId);
    Task<bool> SaveChangesAsync();
}
