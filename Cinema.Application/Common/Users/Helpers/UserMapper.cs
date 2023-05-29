using Cinema.Application.Common.Auth.Dtos;
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

    public static User registerDtoToUser(this RegisterDataDto registerDataDto)
    {
        UserFirstName firstName = new UserFirstName(registerDataDto.FirstName);
        UserLastName lastName = new UserLastName(registerDataDto.LastName);
        Username username = Username.Create(registerDataDto.Username);
        UserEmail email = UserEmail.Create(registerDataDto.Email);
        UserPassword password = UserPassword.Create(registerDataDto.Password);

        return User.Create(firstName, lastName, username, email, password);
    }

    public static UserUpdateDto UserRoleDtoToUpdateDto(this UserRoleDto userRoleDto)
    {
        return new UserUpdateDto
        {
            Role = userRoleDto.Role
        };
    }

    public static User UpdateMapper(this User user, UserUpdateDto userUpdateDto)
    {
        UserFirstName? firstName = null;
        UserLastName? lastName = null;
        UserPassword? password = null;
        UserRole? role = null;

        if (!string.IsNullOrEmpty(userUpdateDto.FirstName)) firstName = new UserFirstName(userUpdateDto.FirstName);
        if(!string.IsNullOrEmpty(userUpdateDto.LastName)) lastName = new UserLastName(userUpdateDto.LastName);
        if(!string.IsNullOrEmpty(userUpdateDto.Password)) password = UserPassword.Create(userUpdateDto.Password);
        if(!string.IsNullOrEmpty(userUpdateDto.Role)) role = UserRole.FromString(userUpdateDto.Role);

        user.Update(firstName, lastName,password, role);
        return user;

    }
}
