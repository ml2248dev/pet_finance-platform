using FinancePlatform.Domain.Entities;
using FinancePlatform.Domain.Enums;

namespace FinancePlatform.Application.DTOs;

public sealed record CreateUserDto
{
    public required string Email { get; init; }
    public required string Password { get; set; }

    public Dictionary<string, Account> Accounts = new Dictionary<string, Account>()
    {
        { "USD", new Account { Currency = Currency.USD } }
    };
}