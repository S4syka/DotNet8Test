using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EFCore.EntityConfigurations;

internal sealed class DeveloperEntityTypeConfiguration : IEntityTypeConfiguration<Developer>
{
    public void Configure(EntityTypeBuilder<Developer> builder)
    {
        AddComments(builder);
        AddColumnNames(builder);
        AddMaxLengths(builder);
    }

    private void AddComments(EntityTypeBuilder<Developer> builder)
    {
        builder.ToTable(tb => tb.HasComment("This is a developer table, containing info about developers"));
    }

    private void AddColumnNames(EntityTypeBuilder<Developer> builder)
    {
        builder.Property(d => d.Id)
            .HasColumnName("DeveloperId");
    }

    private void AddMaxLengths(EntityTypeBuilder<Developer> builder)
    {
        builder.Property(d => d.Email)
            .HasMaxLength(128);

        builder.Property(d => d.Name)
            .HasMaxLength(50);
    }
}
