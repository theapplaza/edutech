using System;

namespace Edutech.Api.Infrastructure.Data;

public class Enrollment
{
    public required int UserId { get; set; }
    public virtual required User User { get; set; }

    public int CourseId { get; set; }
    public virtual required Course  Course { get; set; }
}
