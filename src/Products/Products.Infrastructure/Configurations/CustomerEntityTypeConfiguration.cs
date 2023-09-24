using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.Customers;

namespace Products.Infrastructure.Configurations;

internal class CustomerEntityTypeConfiguration : BaseEntityTypeConfiguration<Customer>
{
    public override void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.PhoneNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(100);

        base.Configure(builder);
    }
}
