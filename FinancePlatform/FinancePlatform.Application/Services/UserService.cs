using FinancePlatform.Application.Interfaces;
using FinancePlatform.Domain.Interfaces;

namespace FinancePlatform.Application.Services;

public class UserService(
    IUserRepository _userRepository
) : IUserService
{
}