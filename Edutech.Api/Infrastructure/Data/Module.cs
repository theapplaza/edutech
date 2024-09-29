using System;

namespace Edutech.Api.Infrastructure.Data;

public class Module
{
    public int ModuleId { get; set; }
    public required string ModuleName { get; set; }

    // Foreign Key for Course
    public int CourseId { get; set; }
    public required Course Course { get; set; }

    public ICollection<Content>? Contents { get; set; }
}
