using Cinema.Application.Common.Auth.Dtos;
using Cinema.Application.Common.Users.Dtos;

namespace Cinema.Application.Common.Auth.UseCases;

public interface IAuthUseCase
{
    Task<UserDto> Register(RegisterDataDto registerDataDto);
    Task<UserDto> Login(LoginDataDto loginDataDto);
    Task Logout();


}
