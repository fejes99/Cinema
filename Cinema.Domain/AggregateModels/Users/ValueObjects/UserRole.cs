using Cinema.Domain.AggregateModels.Users.Helpers;

namespace Cinema.Domain.AggregateModels.Users.ValueObjects;

public enum UserRoleType
{
    Admin,
    LoggedUser
}

public record UserRole
{
    public string Value { get; init; }
    private UserRole(string value) => Value = value;
    public static UserRole Create(UserRoleType userRoleType = UserRoleType.LoggedUser)
    {
        string value = userRoleType.ToString();
        value.ValidateUserRole();
        return new UserRole(value);
    }
    public static UserRole FromString(string value)
    {
        value.ValidateUserRole();
        return new UserRole(value);
    }
}
