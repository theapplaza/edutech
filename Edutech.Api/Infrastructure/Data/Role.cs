using System;

namespace Edutech.Api.Infrastructure.Data;

public class Role
{
    public int RoleId { get; set; }
    public required string RoleName { get; set; }

    public ICollection<User>? Users { get; set; }
}
