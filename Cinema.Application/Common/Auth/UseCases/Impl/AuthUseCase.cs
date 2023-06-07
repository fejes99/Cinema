using BCrypt.Net;
using Cinema.Application.Abstractions;
using Cinema.Application.Common.Auth.Dtos;
using Cinema.Application.Common.Auth.Exceptions;
using Cinema.Application.Common.Users.Dtos;
using Cinema.Application.Common.Users.Helpers;
using Cinema.Domain.AggregateModels.Users;

namespace Cinema.Application.Common.Auth.UseCases.Impl;

public class AuthUseCase : IAuthUseCase
{
    private readonly IUserRepository userRepository;
    public AuthUseCase(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }
    public async Task<UserDto> Login(LoginDataDto loginDataDto)
    {
        User user = await userRepository.GetByEmailAsync(loginDataDto.Email);
        if (user == null) throw new NotFoundException("User with that email dont exist, please try again");

        var verified = BCrypt.Net.BCrypt.Verify(loginDataDto.Password, user.Password.Value);

        if (!verified) throw new InvalidPasswordException("Invalid passowrd, please try again.");

        return user.UserToDto();
    }

    public Task Logout()
    {
        throw new NotImplementedException();
    }

    public async Task<UserDto> Register(RegisterDataDto registerDataDto)
    {
        var userByUsername = await userRepository.GetByUsernameAsync(registerDataDto.Username);
        if (userByUsername != null) throw new UserAlreadyExistsException("User with that username already exists");

        var userByEmail = await userRepository.GetByEmailAsync(registerDataDto.Email);
        if (userByEmail != null) throw new UserAlreadyExistsException("User with that email already exists");


        User user = await userRepository.CreateAsync(registerDataDto.registerDtoToUser());

        return user.UserToDto();
    }
}
