using Cinema.Domain.AggregateModels.Users;
using Cinema.Domain.AggregateModels.Users.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Common.Users.Configurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.Id);

        builder.Property(user => user.Id).HasConversion(
            userId => userId.Value,
            value => new UserId(value));

        builder.Property(user => user.FirstName).HasConversion(
            userFirstName => userFirstName.Value,
            value => new UserFirstName(value));

        builder.Property(user => user.LastName).HasConversion(
            userLastName => userLastName.Value,
            value => new UserLastName(value));

        builder.Property(user => user.Username).HasConversion(
            username => username.Value,
            value => Username.Create(value));

        builder.Property(user => user.Email).HasConversion(
            userEmail => userEmail.Value,
            value => UserEmail.Create(value));

        builder.Property(user => user.Password).HasConversion(
            userPassword => userPassword.Value,
            value => UserPassword.Create(value));

        builder.Property(user => user.Created).HasConversion(
            userCreated => userCreated.Value,
            value => UserCreated.Create());

        builder.Property(user => user.Role).HasConversion(
            userRole => userRole.Value,
            value => UserRole.Create(Enum.Parse<UserRoleType>(value)));

        builder.HasIndex(u => u.Email).IsUnique();
        builder.HasIndex(u => u.Username).IsUnique();
    }
}
