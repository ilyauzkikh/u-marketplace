using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.ProductAggregate;

namespace Products.Infrastructure.Configurations;

internal class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id)
            .HasName("id");

        builder.Property(x => x.Owner)
            .HasColumnName("ownerId")
            .IsRequired();

        builder.Property(x => x.Title)
            .HasColumnName("title")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Description)
            .HasColumnName("description")
            .IsRequired()
            .HasMaxLength(250);

        builder.Property(x => x.Category)
            .HasColumnName("category")
            .IsRequired();

        builder.Property(x => x.Price)
            .HasColumnName("priceId")
            .IsRequired();

        builder.OwnsOne(x => x.Category, c =>
        {
            c.Property(y => y.Id);
            c.WithOwner();
        });

        builder.OwnsOne(x => x.Owner, o =>
        {
            o.Property(x => x.Id);
            o.WithOwner();
        });

        builder.OwnsOne(x => x.Price, p =>
        {
            p.Property(x => x.Id);
            p.WithOwner();
        });
    }
}
