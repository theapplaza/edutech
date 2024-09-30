using Edutech.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Edutech.Api.Infrastructure;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Module> Modules { get; set; }
    public DbSet<Content> Contents { get; set; }
    public DbSet<ContentType> ContentTypes { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // User has a role (Many-to-One)
        modelBuilder.Entity<User>()
            .HasOne(u => u.Role)
            .WithMany(r => r.Users)
            .HasForeignKey(u => u.RoleId);

        // Course has an instructor (Many-to-One)
        modelBuilder.Entity<Course>()
            .HasOne(c => c.Instructor)
            .WithMany(i => i.Courses)
            .HasForeignKey(c => c.InstructorId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

        // Module belongs to a course (Many-to-One)
        modelBuilder.Entity<Module>()
            .HasOne(m => m.Course)
            .WithMany(c => c.Modules)
            .HasForeignKey(m => m.CourseId);

        // Content belongs to a module (Many-to-One)
        modelBuilder.Entity<Content>()
            .HasOne(c => c.Module)
            .WithMany(m => m.Contents)
            .HasForeignKey(c => c.ModuleId);

        // Content has a type (Many-to-One)
        modelBuilder.Entity<Content>()
            .HasOne(c => c.ContentType)
            .WithMany(ct => ct.Contents)
            .HasForeignKey(c => c.ContentTypeId);

        // Enrollment has many-to-many relationship between User and Course
        modelBuilder.Entity<Enrollment>()
            .HasKey(e => new { e.UserId, e.CourseId });

        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.User)
            .WithMany(u => u.Enrollments)
            .HasForeignKey(e => e.UserId);

        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Course)
            .WithMany(c => c.Enrollments)
            .HasForeignKey(e => e.CourseId);
    }

}
