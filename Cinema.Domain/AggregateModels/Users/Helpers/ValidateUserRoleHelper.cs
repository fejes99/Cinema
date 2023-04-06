using Cinema.Domain.AggregateModels.Users.Exceptions;
using Cinema.Domain.AggregateModels.Users.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Domain.AggregateModels.Users.Helpers;

internal static class ValidateUserRoleHelper
{
    public static void ValidateUserRole(this string userRoleValue)
    {
        if(!Enum.TryParse<UserRoleType>(userRoleValue, out var result)) throw new UserRoleException($"Invalid user role: {userRoleValue}");
    }
}
