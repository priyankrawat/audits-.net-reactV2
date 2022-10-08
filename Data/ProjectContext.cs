using audits_.net_react_ramine.Models;
using Microsoft.EntityFrameworkCore;

namespace audits_.net_react_ramine.Data;

public class ProjectContext : DbContext
{
    public DbSet<Project> Projects { get; set; }

	public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
	{
	}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>().ToTable("projects");
    }
}
