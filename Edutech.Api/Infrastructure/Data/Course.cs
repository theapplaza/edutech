using System;

namespace Edutech.Api.Infrastructure.Data;

public class Course
{
    public int CourseId { get; set; }
    public required string CourseName { get; set; }
    public string? Description { get; set; }

    // Foreign Key for Instructor (User)
    public int InstructorId { get; set; }
    
    public virtual User? Instructor { get; set; }

    public virtual ICollection<Module>? Modules { get; set; }
    public virtual ICollection<Enrollment>? Enrollments { get; set; }
}
