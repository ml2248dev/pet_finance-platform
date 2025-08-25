using FinancePlatform.Application.DTOs;
using FinancePlatform.Domain.Entities;

namespace FinancePlatform.Application.Interfaces;

public interface IUserService
{
    public Task<IEnumerable<User>> GetAllUsers();
    public Task CreateUser(CreateUserDto user);
}