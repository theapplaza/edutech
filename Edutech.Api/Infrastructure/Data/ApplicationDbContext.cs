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
    public DbSet<Module> Modules { get; set; }
    public DbSet<Content> Contents { get; set; }
    public DbSet<ContentType> ContentTypes { get; set; }

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

        modelBuilder.Entity<Module>(entity => { entity.ToTable("Modules"); });
        modelBuilder.Entity<ContentType>(entity => { entity.ToTable("ContentTypes"); });
        modelBuilder.Entity<Content>(entity => { entity.ToTable("Contents"); });

        // Configure relationships with explicit foreign keys
        modelBuilder.Entity<Course>()
            .HasMany(c => c.Modules)
            .WithOne(m => m.Course)
            .HasForeignKey(m => m.CourseId)
            .OnDelete(DeleteBehavior.Cascade);

         // Configure relationships with explicit foreign keys
        modelBuilder.Entity<Module>()
                .HasMany(m => m.Contents)
                .WithOne(c => c.Module) // Explicitly specify the navigation property
                .HasForeignKey(c => c.ModuleId)
                .OnDelete(DeleteBehavior.Cascade);
                
        modelBuilder.Entity<Module>()
                .Navigation(e => e.Contents).AutoInclude(); //eager load contents
        modelBuilder.Entity<Content>()
                .Navigation(e => e.ContentType).AutoInclude(); //eager load content type

        #region Seed Data
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

        var module1 = new Module
        {
            Id = Guid.NewGuid(),
            Name = "Product Management Basic",
            CourseId = course1.Id
        };
        modelBuilder.Entity<Module>().HasData(module1);

        var module2 = new Module
        {
            Id = Guid.NewGuid(),
            Name = "Product Management Framework",
            CourseId = course1.Id
        };
        modelBuilder.Entity<Module>().HasData(module2);

        var module3 = new Module
        {
            Id = Guid.NewGuid(),
            Name = "Product Management Tools",
            CourseId = course1.Id
        };
        modelBuilder.Entity<Module>().HasData(module3);

        var module4 = new Module
        {
            Id = Guid.NewGuid(),
            Name = "Introduction to Growth Product Management",
            CourseId = course2.Id
        };
        modelBuilder.Entity<Module>().HasData(module4);

        var module5 = new Module
        {
            Id = Guid.NewGuid(),
            Name = "Growth Product Management Framework",
            CourseId = course2.Id
        };
        modelBuilder.Entity<Module>().HasData(module5);

        var contentTypes = new List<ContentType>
        {
            new ContentType { Id = Guid.NewGuid(), Name = "Video" },
            new ContentType { Id = Guid.NewGuid(), Name = "Text" },
            new ContentType { Id = Guid.NewGuid(), Name = "Quiz" }
        };
        modelBuilder.Entity<ContentType>().HasData(contentTypes);

        var content1 = new Content
        {
            Id = Guid.NewGuid(),
            Title = "Introduction to Product Management",
            ModuleId = module1.Id,
            ContentTypeId = contentTypes.First(c => c.Name == "Video").Id,
            Url = "https://www.youtube.com/watch?v=9Qn0v6wJwPc"
        };
        modelBuilder.Entity<Content>().HasData(content1);

        var content2 = new Content
        {
            Id = Guid.NewGuid(),
            Title = "Career prospect for Product Managers",
            ModuleId = module1.Id,
            ContentTypeId = contentTypes.First(c => c.Name == "Text").Id,
            Url = "https://www.productplan.com/glossary/product-management-framework/"
        };
        modelBuilder.Entity<Content>().HasData(content2);
        
        #endregion Seed Data

    }

}
