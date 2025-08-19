using FinancePlatform.Domain.Enums;

namespace FinancePlatform.Domain.Entities;

public sealed record User
{
    public string Id { get; } = new Guid().ToString();
    public required string Email { get; init; }
    public required string Password { get; set; }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;

    public Dictionary<string, Account> Accounts = new()
    {
        {
            "USD", new Account { Currency = Currency.USD }
        }
    };
}