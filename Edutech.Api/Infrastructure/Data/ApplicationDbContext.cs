using Edutech.Api.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Edutech.Api.Infrastructure;

public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    // public DbSet<User> Users { get; set; }
    // public DbSet<Role> Roles { get; set; }
    // public DbSet<Course> Courses { get; set; }
    // public DbSet<Module> Modules { get; set; }
    // public DbSet<Content> Contents { get; set; }
    // public DbSet<ContentType> ContentTypes { get; set; }
    // public DbSet<Enrollment> Enrollments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>(entity => { entity.ToTable(name: "Users"); });
        modelBuilder.Entity<Role>(entity => { entity.ToTable(name: "Roles"); });
        modelBuilder.Entity<IdentityUserClaim<Guid>>(entity => { entity.ToTable("UserClaims"); });
        modelBuilder.Entity<IdentityUserRole<Guid>>(entity => { entity.ToTable("UserRoles"); });
        modelBuilder.Entity<IdentityUserLogin<Guid>>(entity => { entity.ToTable("UserLogins"); });
        modelBuilder.Entity<IdentityRoleClaim<Guid>>(entity => { entity.ToTable("RoleClaims"); });
        modelBuilder.Entity<IdentityUserToken<Guid>>(entity => { entity.ToTable("UserTokens"); });

        // Configure relationships
        // modelBuilder.Entity<User>()
        //     .HasOne(u => u.Role)
        //     .WithMany(r => r.Users)
        //     .HasForeignKey(u => u.RoleId);

    }

}
