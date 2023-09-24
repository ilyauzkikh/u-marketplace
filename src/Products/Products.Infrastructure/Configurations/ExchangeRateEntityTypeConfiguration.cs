using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.Pricing;

namespace Products.Infrastructure.Configurations;

internal class ExchangeRateEntityTypeConfiguration : BaseEntityTypeConfiguration<ExchangeRate>
{
    public override void Configure(EntityTypeBuilder<ExchangeRate> builder)
    {
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
    }
}
