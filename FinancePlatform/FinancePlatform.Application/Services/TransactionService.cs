using FinancePlatform.Application.Interfaces;
using FinancePlatform.Domain.Interfaces;

namespace FinancePlatform.Application.Services;

public class TransactionService(
    IUserRepository _userRepository,
    ITransactionRepository _transactionRepository
) : ITransactionService
{
}