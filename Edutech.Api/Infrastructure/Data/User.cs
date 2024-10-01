using Microsoft.AspNetCore.Identity;

namespace Edutech.Api.Infrastructure.Data;

public class User : IdentityUser<Guid>
{
    // // Foreign Key
    // public int? RoleId { get; set; }
    
    // public virtual Role? Role { get; set; }

    // public virtual ICollection<Enrollment>? Enrollments { get; set; }
    // public virtual ICollection<Course>? Courses { get; set; } // Instructor's courses
}
