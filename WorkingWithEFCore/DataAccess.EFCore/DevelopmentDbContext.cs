using DataAccess.EFCore.EntityConfigurations;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore.Development;

public class DevelopmentDbContext(string connectionString) : DbContext()
{
    public DbSet<Developer>? developers { get; set; }
    public DbSet<Project>? Projects { get; set; }
    public DbSet<Organization> Organizations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new DeveloperEntityConfiguration().Configure(modelBuilder.Entity<Developer>());
        new ProjectEntityConfiguration().Configure(modelBuilder.Entity<Project>());
        new OrganizationEntityConfiguration().Configure(modelBuilder.Entity<Organization>());
    }
}