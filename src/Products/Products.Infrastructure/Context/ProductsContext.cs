using Microsoft.EntityFrameworkCore;
using Products.Domain.ProductsAggregate;

namespace Products.Infrastructure.Context;

public class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set; }
}
