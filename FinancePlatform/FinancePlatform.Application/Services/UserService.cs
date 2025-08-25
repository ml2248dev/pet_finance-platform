using FinancePlatform.Application.DTOs;
using FinancePlatform.Application.Interfaces;
using FinancePlatform.Domain.DTOs;
using FinancePlatform.Domain.Entities;
using FinancePlatform.Domain.Interfaces;

namespace FinancePlatform.Application.Services;

public class UserService(
    IUserRepository userRepository
) : IUserService
{
    public async Task<IEnumerable<User>> GetAllUsers() => await userRepository.GetAllUsers();

    public async Task CreateUser(CreateUserDto dto)
    {
        var user = new AddUserDto
        {
            Email = dto.Email,
            Password = dto.Password,
            AccountsId = dto.Accounts.Values.Select(a => a.Id).ToList()
        };
        await userRepository.AddUser(user);
    }
}