using audits_.net_react_ramine.Models;
using Microsoft.EntityFrameworkCore;

namespace audits_.net_react_ramine.Data;

public class UserContext : DbContext
{
    public DbSet<User> Users { get; set; }

	public UserContext(DbContextOptions<UserContext> options) : base(options)
	{
	}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("users");
    }
}
