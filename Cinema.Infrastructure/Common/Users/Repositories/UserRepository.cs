using Cinema.Domain.AggregateModels.Users;
using Cinema.Domain.AggregateModels.Users.ValueObjects;
using Cinema.Infrastructure.Common.Users.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Infrastructure.Common.Users.Repositories;

public class UserRepository : IUserRepository
{
    private readonly DatabaseContext context;
    public UserRepository(DatabaseContext context)
    {
        this.context = context;
    }

    public async Task<User> CreateAsync(User user)
    {
        await context.AddAsync(user);
        await SaveChangesAsync();
        return user;
    }

    public async Task DeleteAsync(UserId userId)
    {
        User userToDelete = await GetByIdAsync(userId);
        if(userToDelete.Role.Value != UserRoleType.Admin.ToString())
        {
        context.Remove(userToDelete);
        await SaveChangesAsync();
        }
    }

    public async Task<List<User>> GetAllAsync()
    {
        return await context.Users.OrderByDescending(user=> user.Created).ToListAsync();
    }

    public async Task<User> GetByEmailAsync(string email)
    {
        var user = await context.Users.FirstOrDefaultAsync(user => user.Email == UserEmail.Create(email));
        return user;
    }

    // Todo: Handle default
    public async Task<User> GetByIdAsync(UserId userId)
    {
        var user = await context.Users.FirstOrDefaultAsync(user => user.Id == userId);
        return user ?? throw new UserDontExistInDatabaseException("User with given Id dont exist in Database");
    }

    public async Task<User> GetByUsernameAsync(string username)
    {
        var user = await context.Users.FirstOrDefaultAsync(user => user.Username == Username.Create(username));
        return user;
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<User> UpdateAsync(User user)
    {
        context.Update(user);
        await SaveChangesAsync();
        return user;
    }
}