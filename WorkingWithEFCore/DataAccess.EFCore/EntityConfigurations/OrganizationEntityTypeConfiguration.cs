using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EFCore.EntityConfigurations;

internal sealed class OrganizationEntityTypeConfiguration : IEntityTypeConfiguration<Organization>
{
    public void Configure(EntityTypeBuilder<Organization> builder)
    {
        AddComments(builder);
        AddColumnNames(builder);
    }

    private void AddComments(EntityTypeBuilder<Organization> builder)
    {
        builder.ToTable(tb => tb.HasComment("This is an Organization table, containing info about organizations"));
    }

    private void AddColumnNames(EntityTypeBuilder<Organization> builder)
    {
        builder.Property(o => o.Id)
            .HasColumnName("OrganizationId");
    }
}
