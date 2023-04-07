using Cinema.Domain.AggregateModels.Users.Exceptions;
using Cinema.Domain.AggregateModels.Users.ValueObjects;

namespace Cinema.Domain.AggregateModels.Users.Helpers;

internal static class ValidateUserRoleHelper
{
    public static void ValidateUserRole(this string userRoleValue)
    {
        if(!Enum.TryParse<UserRoleType>(userRoleValue, out var result)) throw new UserRoleException($"Invalid user role: {userRoleValue}");
    }
}
