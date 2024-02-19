using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EFCore.EntityConfigurations;

internal sealed class ProjectEntityTypeConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        AddComments(builder);
        AddColumnNames(builder);
        AddDataRequirements(builder);
    }

    private void AddComments(EntityTypeBuilder<Project> builder)
    {
        builder.ToTable(tb => tb.HasComment("This is a project table, containing info about projects"));
    }

    private void AddColumnNames(EntityTypeBuilder<Project> builder)
    {
        builder.Property(p => p.Id)
            .HasColumnName("ProjectId");
    }

    private void AddDataRequirements(EntityTypeBuilder<Project> builder)
    {
        builder.Property(p => p.Started)
            .HasPrecision(3);
    }
}
