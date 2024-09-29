using System;

namespace Edutech.Api.Infrastructure.Data;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    // Foreign Key
    public int RoleId { get; set; }
    public Role Role { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; }
    public ICollection<Course> Courses { get; set; } // Instructor's courses
}
