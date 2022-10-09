using audits_.net_react_ramine.Models;
using Microsoft.EntityFrameworkCore;

namespace audits_.net_react_ramine.Data;

public class AuditsDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Audit> Audits { get; set; }

    public AuditsDbContext(DbContextOptions<AuditsDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasData(new User
            {
                Id = 1,
                Email = "test@example.com",
                Password = "password",
                FirstName = "User",
                LastName = "Test",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
        modelBuilder.Entity<User>()
            .HasData(new User
            {
                Id = 2,
                Email = "test2@example.com",
                Password = "password",
                FirstName = "User",
                LastName = "Test 2",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });

        var userIds = new[] { 1, 2 };
        var rnd = new Random();
        for (int i = 1; i <= 10; i++)
        {
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = i,
                Description = Faker.Lorem.Paragraph(),
                Title = Faker.Company.CatchPhrase(),
                OwnerId = userIds[rnd.Next(userIds.Length)],
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
        }

        var events = new[]
        {
            "authentication:logout",
            "authentication:new",
            "invoice:create",
            "invoice:send",
            "settings:change"
        };

        var status = new[]
        {
            "started",
            "in progress",
            "finished",
            "error"
        };

        for (int i = 1; i <= 100; i++)
        {
            modelBuilder.Entity<Audit>().HasData(new Audit
            {
                Event = events[rnd.Next(events.Length)],
                Status = status[rnd.Next(status.Length)],
                Message = Faker.Lorem.Paragraph(),
                Context = "{}",
                UserId = userIds[rnd.Next(userIds.Length)],
                Id = i,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
        }
    }
}
