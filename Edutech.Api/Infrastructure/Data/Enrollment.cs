using System;

namespace Edutech.Api.Infrastructure.Data;

public class Enrollment
{
    public int UserId { get; set; }
    public User User { get; set; }

    public int CourseId { get; set; }
    public Course Course { get; set; }
}
