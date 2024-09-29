using System;

namespace Edutech.Api.Infrastructure.Data;

public class User
{
    public int UserId { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }

    // Foreign Key
    public int RoleId { get; set; }
    public required Role Role { get; set; }

    public ICollection<Enrollment>? Enrollments { get; set; }
    public ICollection<Course>? Courses { get; set; } // Instructor's courses
}
