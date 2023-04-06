using Cinema.Application.Common.Users.Dtos;
using Cinema.Application.Common.Users.Helpers;
using Cinema.Domain.AggregateModels.Users;
using Cinema.Domain.AggregateModels.Users.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Application.Common.Users.UseCases.Impl;

public class UserUseCase : IUserUseCase
{
    private readonly IUserRepository repository;

    public UserUseCase(IUserRepository repository)
    {
        this.repository = repository;
    }

    public async Task<UserDto> CreateUser(UserCreateDto userCreateDto)
    {
        User createdUser = await repository.CreateAsync(userCreateDto.CreateDtoToUser());
        UserDto createdUserDto = createdUser.UserToDto();
        return createdUserDto;
    }

    public async Task DeleteUser(Guid id)
    {
        await repository.DeleteAsync(new UserId(id));
    }

    public async Task<UserDto> GetUserById(Guid id)
    {
        User user = await repository.GetByIdAsync(new UserId(id));
        UserDto userDto = user.UserToDto();
        return userDto;
    }

    public async Task<List<UserDto>> GetUsers()
    {
        List<User> users = await repository.GetAllAsync();
        List<UserDto> userDtos = users.Select(user => user.UserToDto()).ToList();
        return userDtos;
    }

    public async Task<UserDto> UpdateUser(Guid id, UserUpdateDto userUpdateDto)
    {
        User userToUpdate = await repository.GetByIdAsync(new UserId(id));
        User updatedUser = await repository.UpdateAsync(userToUpdate.UpdateMapper(userUpdateDto));
        UserDto updatedUserDto = updatedUser.UserToDto();
        return updatedUserDto;
    }
}
