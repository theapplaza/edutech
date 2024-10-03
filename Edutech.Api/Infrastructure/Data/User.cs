using Microsoft.AspNetCore.Identity;

namespace Edutech.Api.Infrastructure.Data;

public class User : IdentityUser<Guid>
{
    public ICollection<Course>? Courses { get; set; }
}
