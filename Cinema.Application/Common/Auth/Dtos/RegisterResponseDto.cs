using Cinema.Application.Common.Users.Dtos;

namespace Cinema.Application.Common.Auth.Dtos;

public class RegisterResponseDto
{
    public UserDto User { get; set; }
    public string Token { get; set; }
}
