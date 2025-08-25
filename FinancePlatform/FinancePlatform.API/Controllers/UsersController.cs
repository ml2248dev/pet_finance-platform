using FinancePlatform.Application.DTOs;
using FinancePlatform.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using FinancePlatform.Domain.Entities;
using FinancePlatform.Domain.Enums;

namespace FinancePlatform.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(
    IUserService userService
) : ControllerBase
{
    private static readonly List<User> Users = new();

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
    {
        var users = await userService.GetAllUsers();
        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUserDto(LoginUserDto dto)
    {
        var user = new CreateUserDto()
        {
            Email = dto.Email,
            Password = dto.Password,
        };
        await userService.CreateUser(user);
        return Ok();
    }
}