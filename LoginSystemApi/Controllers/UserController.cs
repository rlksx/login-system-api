using LoginSystemApi.Data;
using LoginSystemApi.Models;
using LoginSystemApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoginSystemApi.Controllers;

[ApiController]
public class UserController : ControllerBase
{
    [HttpGet("api/v1/")]
    public async Task<IActionResult> GetAsync(
        [FromServices] AppDataContext context)
    {
        var users = context.Users
            .AsTracking().ToListAsync();
        
        return Ok(users);
    }
    
    [HttpPost("api/v1/register")]
    public async Task<IActionResult> PostAsync(
        [FromServices] AppDataContext context,
        [FromBody] UserRegisterViewModel model)
    {
        try
        {  
            var user = new User
            {
                Name = model.Name,
                Email = model.Email,
                Bio = model.Bio,
                PasswordHash = model.Password,
                Slug = model.Email.ToLower()
                    .Replace("@", "-")
                    .Replace(".","-")
            };

            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();

            return Created("api/v1/register", user);
        }
        catch  (Exception exception)
        {
            return StatusCode(500, "Falha interna do servidor!");
        }
    }
}