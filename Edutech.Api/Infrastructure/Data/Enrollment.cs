using System;

namespace Edutech.Api.Infrastructure.Data;

public class Enrollment
{
    public int UserId { get; set; }
    public required User User { get; set; }

    public int CourseId { get; set; }
    public required Course  Course { get; set; }
}
