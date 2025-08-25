namespace FinancePlatform.Application.DTOs;

public sealed record LoginUserDto
{
    public required string Email { get; init; }
    public required string Password { get; init; }
}