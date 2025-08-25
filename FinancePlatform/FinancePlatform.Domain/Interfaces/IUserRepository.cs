using FinancePlatform.Domain.DTOs;
using FinancePlatform.Domain.Entities;

namespace FinancePlatform.Domain.Interfaces;

public interface IUserRepository
{
    public Task<IEnumerable<User>> GetAllUsers();
    public Task AddUser(AddUserDto user);
}