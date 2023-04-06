using Cinema.Application.Common.Users.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Users.UseCases;

public interface IUserUseCase
{
    Task<List<UserDto>> GetUsers();
    Task<UserDto> GetUserById(Guid id);
    Task<UserDto> CreateUser(UserCreateDto userCreateDto);
    Task<UserDto> UpdateUser(Guid id, UserUpdateDto userUpdateDto);
    Task DeleteUser(Guid id);
}
