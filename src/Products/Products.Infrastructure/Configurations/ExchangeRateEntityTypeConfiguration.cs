using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.PriceAggregate;

namespace Products.Infrastructure.Configurations;

internal class ExchangeRateEntityTypeConfiguration : IEntityTypeConfiguration<ExchangeRate>
{
    public void Configure(EntityTypeBuilder<ExchangeRate> builder)
    {
        builder.HasKey(x => x.Id)
            .HasName("id");

        builder.Property(x => x.First)
            .HasColumnName("first_currency")
            .IsRequired();

        builder.Property(x => x.Second)
            .HasColumnName("second_currency")
            .IsRequired();

        builder.Property(x => x.FirstToSecond)
            .HasColumnName("first_to_second_rate")
            .IsRequired();

        builder.Property(x => x.SecondToFirst)
            .HasColumnName("second_to_frist_rate")
            .IsRequired();

        builder.OwnsOne(x => x.First, c =>
        {
            c.Property(y => y.Id);
            c.WithOwner();
        });

        builder.OwnsOne(x => x.Second, c =>
        {
            c.Property(y => y.Id);
            c.WithOwner();
        });
    }
}
