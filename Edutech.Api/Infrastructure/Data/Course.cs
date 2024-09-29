using System;

namespace Edutech.Api.Infrastructure.Data;

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string Description { get; set; }

    // Foreign Key for Instructor (User)
    public int InstructorId { get; set; }
    public User Instructor { get; set; }

    public ICollection<Module> Modules { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; }
}
