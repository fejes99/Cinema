using Cinema.Application.Common.Users.Dtos;
using Cinema.Domain.AggregateModels.Users;
using Cinema.Domain.AggregateModels.Users.ValueObjects;

namespace Cinema.Application.Common.Users.Helpers;

public static class UserMapper
{
    public static UserDto UserToDto(this User user)
    {
        return new UserDto
        {
            Id = user.Id.Value,
            FirstName = user.FirstName.Value,
            LastName = user.LastName.Value,
            Username = user.Username.Value,
            Email = user.Email.Value,
            Password = user.Password.Value,
            Created = user.Created.Value,
            Role = user.Role.Value
        };
    }

    public static ProjectionUserDto UserToProjectionUserDto(this User user)
    {
        return new ProjectionUserDto
        {
            Id = user.Id.Value,
            FirstName = user.FirstName.Value,
            LastName = user.LastName.Value,
            Username = user.Username.Value,
            Email = user.Email.Value
        };
    }

    public static User CreateDtoToUser(this UserCreateDto userCreateDto)
    {
        UserFirstName firstName = new UserFirstName(userCreateDto.FirstName);
        UserLastName lastName = new UserLastName(userCreateDto.LastName);
        Username username = Username.Create(userCreateDto.Username);
        UserEmail email = UserEmail.Create(userCreateDto.Email);
        UserPassword password = UserPassword.Create(userCreateDto.Password);

        return User.Create(firstName, lastName, username, email, password);
    }

    public static User UpdateMapper(this User user, UserUpdateDto userUpdateDto)
    {
        UserFirstName? firstName = null;
        UserLastName? lastName = null;
        Username? username = null;
        UserEmail? email = null;
        UserPassword? password = null;

        if(!string.IsNullOrEmpty(userUpdateDto.FirstName)) firstName = new UserFirstName(userUpdateDto.FirstName);
        if(!string.IsNullOrEmpty(userUpdateDto.LastName)) lastName = new UserLastName(userUpdateDto.LastName);
        if(!string.IsNullOrEmpty(userUpdateDto.Username)) username = Username.Create(userUpdateDto.Username);
        if(!string.IsNullOrEmpty(userUpdateDto.Email)) email = UserEmail.Create(userUpdateDto.Email);
        if(!string.IsNullOrEmpty(userUpdateDto.Password)) password = UserPassword.Create(userUpdateDto.Password);

        user.Update(firstName, lastName, username, email, password);
        return user;

    }
}
