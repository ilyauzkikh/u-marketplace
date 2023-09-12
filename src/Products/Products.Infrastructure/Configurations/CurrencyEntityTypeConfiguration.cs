using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.PriceAggregate;
using Products.Infrastructure.Context;
using System.Reflection.Emit;

namespace Products.Infrastructure.Configurations;

internal class CurrencyEntityTypeConfiguration : IEntityTypeConfiguration<Currency>
{
    public void Configure(EntityTypeBuilder<Currency> builder)
    {
        builder.ToTable("currencies", ProductsContext.DEFAULT_SCHEMA);

        builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.Type)
            .HasColumnName("type")
        .IsRequired(true);
    }
}
