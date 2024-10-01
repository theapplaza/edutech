using Edutech.Api.Infrastructure.Data;
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

    }

}
