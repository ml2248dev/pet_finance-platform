using FinancePlatform.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace FinancePlatform.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(
    NpgsqlConnection connection,
    IUserService _userService
) : ControllerBase
{
}