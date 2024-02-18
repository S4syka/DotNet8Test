using DataAccess.EFCore.EntityConfigurations;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

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
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DevelopmentDbContext).Assembly);
    }
}