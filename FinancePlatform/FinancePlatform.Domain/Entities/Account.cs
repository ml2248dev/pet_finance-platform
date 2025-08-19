using FinancePlatform.Domain.Enums;

namespace FinancePlatform.Domain.Entities;

public sealed record Account
{
    public string Id { get; } = Guid.NewGuid().ToString();
    public required Currency Currency { get; init; }
    public decimal Balance { get; set; } = decimal.Zero;
}