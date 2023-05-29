namespace Cinema.Application.Common.Users.Dtos;

public class UserDto
{
    public Guid Id { get;  set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime Created { get; set; }
    public string Role { get; set; } = string.Empty;
}
