using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.PriceAggregate;

namespace Products.Infrastructure.Configurations;

internal class CurrencyEntityTypeConfiguration : IEntityTypeConfiguration<Currency>
{
    public void Configure(EntityTypeBuilder<Currency> builder)
    {
        builder.HasKey(x => x.Id)
            .HasName("id");

        builder.Property(x => x.Type)
            .IsRequired();

        builder.OwnsMany(x => x.ExchangeRates, rates =>
        {
            rates.Property(x => x.First);
            rates.WithOwner();
        });
    }
}
