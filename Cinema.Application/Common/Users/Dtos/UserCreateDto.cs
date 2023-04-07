namespace Cinema.Application.Common.Users.Dtos;

public class UserCreateDto
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
