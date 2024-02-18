using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EFCore.EntityConfigurations;

internal sealed class OrganizationEntityTypeConfiguration : IEntityTypeConfiguration<Organization>
{
    public void Configure(EntityTypeBuilder<Organization> builder)
    {
        AddComments(builder);
        AddDataRequirements(builder);
        AddColumnNames(builder);
        AddColumnOrders(builder);
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

    private void AddDataRequirements(EntityTypeBuilder<Organization> builder)
    {
        builder.Property(o => o.Name)
            .HasMaxLength(50)
            .IsRequired();
    }

    private void AddColumnOrders(EntityTypeBuilder<Organization> builder)
    {
        builder.Property(o => o.Id)
            .HasColumnOrder(0);

        builder.Property(o => o.Description)
            .HasColumnOrder(1);

        builder.Property(o => o.Name)
            .HasColumnOrder(2);
    }
}
