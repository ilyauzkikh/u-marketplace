using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.PriceAggregate;

namespace Products.Infrastructure.Configurations;

internal class PriceEntityTypeConfiguration : IEntityTypeConfiguration<Price>
{
    public void Configure(EntityTypeBuilder<Price> builder)
    {
        builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

        builder.Property(x => x.Amount)
            .HasColumnName("amount")
            .IsRequired();

        builder.OwnsOne(x => x.BaseCurrency);

        //builder.OwnsMany(x => x.BaseCurrency.ExchangeRates);
    }
}
