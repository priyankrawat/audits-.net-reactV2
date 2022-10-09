using audits_.net_react_ramine.Models;
using Microsoft.EntityFrameworkCore;

namespace audits_.net_react_ramine.Data;

public class AuditsDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Project> Projects { get; set; }

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
                LastName = "Test"
            });
        modelBuilder.Entity<User>()
            .HasData(new User
            {
                Id = 2,
                Email = "test2@example.com",
                Password = "password",
                FirstName = "User",
                LastName = "Test 2"
            });

        var userIds = new[] { 1, 2 };
        var rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = i + 1,
                Description = Faker.Lorem.Paragraph(),
                Title = Faker.Company.CatchPhrase(),
                OwnerId = userIds[rnd.Next(userIds.Length)]
            });
        }

        modelBuilder.Entity<Project>().ToTable("projects");
    }
}
