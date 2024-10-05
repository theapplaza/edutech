using System.ComponentModel.DataAnnotations;

namespace Edutech.Api.Infrastructure.Data;

public class Module
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public string? Description { get; set; }
    // Foreign Key for Course
    public Guid CourseId { get; set; }
    public Course? Course { get; set; }
    public ICollection<Content>? Contents { get; set; }
}
