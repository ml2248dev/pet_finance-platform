namespace FinancePlatform.Domain.Entities;

public sealed record User
{
    public string Id { get; } = Guid.NewGuid().ToString();
    public required string Email { get; init; }
    public required string Password { get; set; }
    public required Dictionary<string, Account> Accounts { get; init; }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
}