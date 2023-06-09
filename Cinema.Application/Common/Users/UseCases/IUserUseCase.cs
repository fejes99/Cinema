﻿using Cinema.Application.Common.Auth.Dtos;
using Cinema.Application.Common.Users.Dtos;

namespace Cinema.Application.Common.Users.UseCases;

public interface IUserUseCase
{
    Task<List<UserDto>> GetUsers();
    Task<UserDto> GetUserById(Guid id);
    Task<UserDto> CreateUser(RegisterDataDto registerDataDto);
    Task<UserDto> UpdateUser(Guid id, UserUpdateDto userUpdateDto);
    Task<UserDto> UpdateUserRole(Guid id, UserRoleDto userRole);
    Task<UserDto> UpdatePersonalData(Guid id, UserUpdateDto userUpdateDto);
    Task DeleteUser(Guid id);
}
