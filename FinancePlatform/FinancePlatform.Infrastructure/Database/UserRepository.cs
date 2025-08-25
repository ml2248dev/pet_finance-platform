using System.Data;
using Dapper;
using FinancePlatform.Domain.DTOs;
using FinancePlatform.Domain.Entities;
using FinancePlatform.Domain.Interfaces;

namespace FinancePlatform.Infrastructure.Database;

public class UserRepository(
    IDbConnection dbConnection
) : IUserRepository
{
    public async Task<IEnumerable<User>> GetAllUsers()
    {
        const string sql = """
                           SELECT
                           id as Id,
                           login as Login,
                           password as Password,
                           accountsId as AccountsId
                           FROM users
                           """;
        return await dbConnection.QueryAsync<User>(sql);
    }

    public async Task AddUser(AddUserDto user)
    {
        const string sql = $"""
                            INSERT into users (email, password, accounts_id)
                            VALUES (
                                    @{nameof(AddUserDto.Email)},
                                    @{nameof(AddUserDto.Password)},
                                    @{nameof(AddUserDto.AccountsId)}
                                    );
                            """;
        await dbConnection.ExecuteAsync(sql, user);
    }
}