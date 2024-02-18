using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EFCore.EntityConfigurations;

internal sealed class ProjectEntityTypeConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        AddComments(builder);
    }

    private void AddComments(EntityTypeBuilder<Project> builder)
    {
        builder.ToTable(tb => tb.HasComment("This is a project table, containing info about projects"));
    }
}
