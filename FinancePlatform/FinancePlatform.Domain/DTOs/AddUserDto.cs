namespace FinancePlatform.Domain.DTOs;

public sealed record AddUserDto
{
    public required string Email { get; init; }
    public required string Password { get; init; }
    public required List<string> AccountsId { get; init; }
}