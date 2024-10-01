using Edutech.Api.Application;
using Edutech.Api.Infrastructure.Data;
using Edutech.Api.RequestResponseModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Edutech.Api.Presentation;

[ApiController]
[Route("api/[controller]")]
public class AuthenticationController (UserManager<User> userManager,  RoleManager<Role> roleManager, AuthSenticationService authService): ControllerBase
{
    private readonly UserManager<User> _userManager = userManager;
    private readonly RoleManager<Role> _roleManager = roleManager;
    private readonly AuthSenticationService _authService = authService;

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestModel model)
    {
        var user = await _userManager.FindByNameAsync(model.Username);
        if (user == null || !await _userManager.CheckPasswordAsync(user, model.Password))
        {
            return Unauthorized();
        }

        var token = await _authService.GenerateJwtToken(user);
        return Ok(new { Token = token });
    }

     // POST: api/auth/register-student
    [HttpPost("register-student")]
    public async Task<IActionResult> RegisterStudent([FromBody] RegisterStudentModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        // Check if the role "Student" exists, if not, create it
        if (!await _roleManager.RoleExistsAsync("Student"))
        {
            var roleResult = await _roleManager.CreateAsync(new Role { Name = "Student" });
            if (!roleResult.Succeeded)
            {
                return StatusCode(500, "Error while creating the Student role.");
            }
        }

        // Create a new user (Student)
        var student = new User
        {
            UserName = model.Username,
            Email = model.Email,
        };

        var result = await _userManager.CreateAsync(student, model.Password);
        if (!result.Succeeded)
        {
            return BadRequest(result.Errors);
        }

        // Assign the "Student" role to the newly created user
        var roleAssignResult = await _userManager.AddToRoleAsync(student, "Student");
        if (!roleAssignResult.Succeeded)
        {
            return StatusCode(500, "Error while assigning the Student role.");
        }

                // Generate JWT token for the new student
        var token = await _authService.GenerateJwtToken(student);

        // Return the token
        return Ok(new
        {
            Message = "Student registered successfully.",
            Token = token
        });

    }
}

