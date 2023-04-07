namespace Cinema.Application.Common.Users.Dtos;

public class UserUpdateDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Username { get; set; }
    public string? Email { get; private set; }
    public string? Password { get; set; }
    public string? Role { get; set; }
}
