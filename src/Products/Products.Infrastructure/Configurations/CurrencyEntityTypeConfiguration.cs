using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.Pricing;
using Products.Infrastructure.Context;

namespace Products.Infrastructure.Configurations;

internal class CurrencyEntityTypeConfiguration : BaseEntityTypeConfiguration<Currency>
{
    public override void Configure(EntityTypeBuilder<Currency> builder)
    {
        builder.ToTable("currencies", ProductsContext.DEFAULT_SCHEMA);

        builder.Property(x => x.Type)
            .HasColumnName("type")
            .IsRequired(true);

        base.Configure(builder);
    }
}
