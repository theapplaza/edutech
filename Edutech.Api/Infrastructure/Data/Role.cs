using Microsoft.AspNetCore.Identity;

namespace Edutech.Api.Infrastructure.Data;

public class Role : IdentityRole<Guid>
{
    public ICollection<User>? Users { get; set; }
}
