using FinancePlatform.Domain.Enums;

namespace FinancePlatform.Domain.Entities;

public sealed record Transaction
{
    public string Id { get; } = Guid.NewGuid().ToString();
    public DateTime Date { get; } = DateTime.UtcNow;
    public required TransactionType Type { get; init; }

    public string FromAccountId { get; init; } = string.Empty;
    public required string ToAccountId { get; init; }
    public required decimal Amount { get; init; }
}