using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.PriceAggregate;

namespace Products.Infrastructure.Configurations;

internal class PriceEntityTypeConfiguration : IEntityTypeConfiguration<Price>
{
    public void Configure(EntityTypeBuilder<Price> builder)
    {
        builder.HasKey(x => x.Id)
            .HasName("id");

        builder.Property(x => x.Amount)
            .HasColumnName("amount")
            .IsRequired();

        builder.Property(x => x.BaseCurrency)
            .HasColumnName("currency")
            .IsRequired();

        builder.OwnsOne(x => x.BaseCurrency, c =>
        {
            c.Property(y => y.Id);
            c.WithOwner();
        });
    }
}
