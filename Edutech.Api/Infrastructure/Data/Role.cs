using Microsoft.AspNetCore.Identity;

namespace Edutech.Api.Infrastructure.Data;

public class Role : IdentityRole
{
    public int RoleId { get; set; }
    public required string RoleName { get; set; }

    public ICollection<User>? Users { get; set; }
}
