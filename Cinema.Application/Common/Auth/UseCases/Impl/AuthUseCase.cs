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
        // TODO: Implement password hasher
        User user = await userRepository.GetByEmailAsync(loginDataDto.Email);

        if (user.Password.Value != loginDataDto.Password) throw new InvalidPasswordException("Wrong password");

        return user.UserToDto();
    }

    public Task Logout()
    {
        throw new NotImplementedException();
    }

    public async Task<UserDto> Register(RegisterDataDto registerDataDto)
    {
        User user = await userRepository.CreateAsync(registerDataDto.registerDtoToUser());

        return user.UserToDto();
    }
}
