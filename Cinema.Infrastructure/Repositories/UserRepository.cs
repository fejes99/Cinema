using Cinema.Domain.AggregateModels.Movies.ValueObjects;
using Cinema.Domain.AggregateModels.Users;
using Cinema.Domain.AggregateModels.Users.ValueObjects;
using Cinema.Infrastructure.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Repositories
{
    internal class UserRepository : IUserRepository
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

        public async Task DeleteAsync(User user)
        {
            context.Remove(user);
            await SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await context.Users.ToListAsync();
        }

        // Todo: Handle default
        public async Task<User> GetByIdAsync(UserId userId)
        {
            var user = await context.Users.FirstOrDefaultAsync(user => user.Id == userId);
            return user ?? throw new UserDontExistInDatabaseException("User with given Id dont exist in Database");
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
}