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
    public DbSet<Course> Courses { get; set; }
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

           // Configure many-to-many relationship between User and Course
            modelBuilder.Entity<User>()
                .HasMany(u => u.Courses)
                .WithMany(c => c.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserCourses",
                    l => l.HasOne<Course>().WithMany().HasForeignKey("CourseId"),
                    r => r.HasOne<User>().WithMany().HasForeignKey("UserId"));


        // Seed data for roles
        var adminRole = new Role { Id = Guid.NewGuid(), Name = "Admin", NormalizedName = "ADMIN" };
        var studentRole = new Role { Id = Guid.NewGuid(), Name = "Student", NormalizedName = "STUDENT" };
        var instructorRole = new Role { Id = Guid.NewGuid(), Name = "Instructor", NormalizedName = "INSTRUCTOR" };

        modelBuilder.Entity<Role>().HasData(
            adminRole,
            studentRole,
            instructorRole
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
            EmailConfirmed = true
        };
        adminUser.PasswordHash = hasher.HashPassword(adminUser, "Admin@123");

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
        var studentUser1 = new User
        {
            Id = Guid.NewGuid(),
            UserName = "student1",
            NormalizedUserName = "STUDENT1",
            Email = "student1@edutech.com",
            NormalizedEmail = "STUDENT1@EDUTECH.COM",
            EmailConfirmed = true
        };
        studentUser1.PasswordHash = hasher.HashPassword(studentUser1, "Student1@123");

        modelBuilder.Entity<User>().HasData(studentUser1);
        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
            new IdentityUserRole<Guid>
            {
                UserId = studentUser1.Id,
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
            EmailConfirmed = true
        };
        studentUser2.PasswordHash = hasher.HashPassword(studentUser2, "Student2@123");

        modelBuilder.Entity<User>().HasData(studentUser2);

        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
            new IdentityUserRole<Guid>
            {
                UserId = studentUser2.Id,
                RoleId = studentRole.Id
            }
        );

        // Seed data for instructor1
        var instructorUser1 = new User
        {
            Id = Guid.NewGuid(),
            UserName = "instructor1",
            NormalizedUserName = "INSTRUCTOR1",
            Email = "instructor1@edutech.com",
            NormalizedEmail = "INSTRUCTOR1@EDUTECH.COM",
            EmailConfirmed = true
        };
        instructorUser1.PasswordHash = hasher.HashPassword(instructorUser1, "Instructor1@123");
        modelBuilder.Entity<User>().HasData(instructorUser1);
        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
            new IdentityUserRole<Guid>
            {
                UserId = instructorUser1.Id,
                RoleId = instructorRole.Id
            }
        );

        // Seed data for instructor2
        var instructorUser2 = new User
        {
            Id = Guid.NewGuid(),
            UserName = "instructor2",
            NormalizedUserName = "INSTRUCTOR2",
            Email = "instructor2@edutech.com",
            NormalizedEmail = "INSTRUCTOR2@EDUTECH.COM",
            EmailConfirmed = true
        };
        instructorUser2.PasswordHash = hasher.HashPassword(instructorUser2, "Instructor2@123");
        modelBuilder.Entity<User>().HasData(instructorUser2);
        modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
            new IdentityUserRole<Guid>
            {
                UserId = instructorUser2.Id,
                RoleId = instructorRole.Id
            }
        );

        // Seed data for courses
        var course1 = new Course
        {
            Id = Guid.NewGuid(),
            Name = "Introduction to Product Management",
            Description = "This course is designed to introduce student to the world of product management"
        };
        
        modelBuilder.Entity<Course>().HasData(course1);
        //assign instructor1 to course1
        modelBuilder.Entity("UserCourses").HasData(
            new { CourseId = course1.Id, UserId = instructorUser1.Id },
            new { CourseId = course1.Id, UserId = studentUser1.Id },
            new { CourseId = course1.Id, UserId = studentUser2.Id }
        );

        var course2 = new Course
        {
            Id = Guid.NewGuid(),
            Name = "Growth Product Management",
            Description = "This course is for students who want to learn how to grow a product"
        };
        modelBuilder.Entity<Course>().HasData(course2);
        //assign instructor1 to course1
        modelBuilder.Entity("UserCourses").HasData(
            new { CourseId = course2.Id, UserId = instructorUser2.Id },
            new { CourseId = course2.Id, UserId = studentUser1.Id }
        );

    }

}
