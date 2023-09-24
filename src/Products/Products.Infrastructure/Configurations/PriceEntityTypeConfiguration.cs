using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.Pricing;

namespace Products.Infrastructure.Configurations;

internal class PriceEntityTypeConfiguration : BaseEntityTypeConfiguration<Price>
{
    public override void Configure(EntityTypeBuilder<Price> builder)
    {
        builder.Property(x => x.Amount)
            .HasColumnName("amount")
            .IsRequired();

        builder.OwnsOne(x => x.BaseCurrency);

        base.Configure(builder);
    }
}
