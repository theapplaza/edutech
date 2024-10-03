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

        // Seed data for roles
        var adminRole = new Role { Id = Guid.NewGuid(), Name = "Admin", NormalizedName = "ADMIN" };
        var studentRole = new Role { Id = Guid.NewGuid(), Name = "Student", NormalizedName = "STUDENT" };

        modelBuilder.Entity<Role>().HasData(
            adminRole,
            studentRole
        );

        // Seed data for users
        var hasher = new PasswordHasher<User>();
        var adminUser = new User
        {
            Id = Guid.NewGuid(),
            UserName = "admin",
            NormalizedUserName = "ADMIN",
            Email = "admin@edutech.com",
            NormalizedEmail = "ADMIN@EDUTECH.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Admin@123")
        };

        modelBuilder.Entity<User>().HasData(adminUser);

        // Assign admin role to admin user
        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
            new IdentityUserRole<Guid>
            {
                UserId = adminUser.Id,
                RoleId = adminRole.Id
            }
        );

        // Seed data for student
        var studentUser = new User
        {
            Id = Guid.NewGuid(),
            UserName = "student1",
            NormalizedUserName = "STUDENT1",
            Email = "student1@edutech.com",
            NormalizedEmail = "STUDENT1@EDUTECH.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Student1@123")
        };

        modelBuilder.Entity<User>().HasData(studentUser);
        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
            new IdentityUserRole<Guid>
            {
                UserId = studentUser.Id,
                RoleId = studentRole.Id
            }
        );

        //seed student 2
        var studentUser2 = new User
        {
            Id = Guid.NewGuid(),
            UserName = "student2",
            NormalizedUserName = "STUDENT2",
            Email = "student2@edutech.com",
            NormalizedEmail = "STUDENT2@EDUTECH.COM",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Student2@123")
        };

        modelBuilder.Entity<User>().HasData(studentUser2);

        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
            new IdentityUserRole<Guid>
            {
                UserId = studentUser2.Id,
                RoleId = studentRole.Id
            }
        );


    }

}
