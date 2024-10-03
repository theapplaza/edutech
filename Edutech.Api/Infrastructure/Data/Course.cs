using System.ComponentModel.DataAnnotations;

namespace Edutech.Api.Infrastructure.Data;

public class Course
{
    [Key]
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public ICollection<User>? Users { get; set; }
}
