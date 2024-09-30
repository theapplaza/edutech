using Microsoft.AspNetCore.Identity;

namespace Edutech.Api.Infrastructure.Data;

public class User : IdentityUser
{
    public int UserId { get; set; }
    public required string Username { get; set; }
    public new required string Email { get; set; }
    public string? Password { get; set; }

    // Foreign Key
    public int RoleId { get; set; }
    public Role? Role { get; set; }

    public ICollection<Enrollment>? Enrollments { get; set; }
    public ICollection<Course>? Courses { get; set; } // Instructor's courses
}
