using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.ProductAggregate;
using Products.Infrastructure.Context;

namespace Products.Infrastructure.Configurations;

internal class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("categories", ProductsContext.DEFAULT_SCHEMA);

        builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

        builder.Property(x => x.Id)
            .HasColumnName("id");

        builder.Property(x => x.Title)
            .HasColumnName("title")
            .IsRequired(true);

        builder.Property(x => x.Description)
            .HasColumnName("description")
            .IsRequired(true);
    }
}
