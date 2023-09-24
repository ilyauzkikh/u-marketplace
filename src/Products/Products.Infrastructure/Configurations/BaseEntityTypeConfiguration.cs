using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.BaseEntities;

namespace Products.Infrastructure.Configurations;

internal abstract class BaseEntityTypeConfiguration<T> : IEntityTypeConfiguration<T> where T : Entity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(x => x.Id)
            .HasName($"pk_id_{typeof(T).Name.ToLower()}");
    }
}
