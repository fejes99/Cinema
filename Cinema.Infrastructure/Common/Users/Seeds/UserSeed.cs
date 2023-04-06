using Cinema.Domain.AggregateModels.Users;
using Cinema.Domain.AggregateModels.Users.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Common.Users.Seeds;

internal class UserSeed : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasData(
            User.Create(
                new UserFirstName("David"),
                new UserLastName("Fejes"),
                Username.Create("davidfejes"),
                UserEmail.Create("david.fejes@gmail.com"),
                UserPassword.Create("davidfejes")
            ),
            User.Create(
                new UserFirstName("Stefan"),
                new UserLastName("Bulaja"),
                Username.Create("stefanbulaja"),
                UserEmail.Create("stefan.bulaja@gmail.com"),
                UserPassword.Create("stefanbulaja")
            ),
            User.Create(
                new UserFirstName("Andrija"),
                new UserLastName("Tasic"),
                Username.Create("andrijatasic"),
                UserEmail.Create("andija.tasic@gmail.com"),
                UserPassword.Create("andrijatasic")
            )
        );
    }
}
