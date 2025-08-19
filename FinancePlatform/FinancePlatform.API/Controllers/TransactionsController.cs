using FinancePlatform.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinancePlatform.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransactionsController(
    IUserService _userService,
    ITransactionService _transactionService
) : ControllerBase
{
}