using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EFCore.EntityConfigurations;

internal sealed class DeveloperEntityTypeConfiguration : IEntityTypeConfiguration<Developer>
{
    public void Configure(EntityTypeBuilder<Developer> builder)
    {
        AddComments(builder);
    }

    private void AddComments(EntityTypeBuilder<Developer> builder)
    {
        builder.ToTable(tb => tb.HasComment("This is a developer table, containing info about developers"));
    }
}
