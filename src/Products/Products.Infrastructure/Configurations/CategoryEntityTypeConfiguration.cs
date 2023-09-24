using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.Products;
using Products.Infrastructure.Context;

namespace Products.Infrastructure.Configurations;

internal class CategoryEntityTypeConfiguration : BaseEntityTypeConfiguration<Category>
{
    public override void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("categories", ProductsContext.DEFAULT_SCHEMA);

        builder.Property(x => x.Title)
            .HasColumnName("title")
            .IsRequired(true);

        builder.Property(x => x.Description)
            .HasColumnName("description")
            .IsRequired(true);

        builder.HasOne(x => x.Parent);

        base.Configure(builder);
    }
}
