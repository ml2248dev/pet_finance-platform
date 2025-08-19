using FinancePlatform.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinancePlatform.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(
    IUserService _userService
) : ControllerBase
{
}