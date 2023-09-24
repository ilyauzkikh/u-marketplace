using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Products.Domain.Customers;
using Products.Domain.Pricing;
using Products.Domain.Products;
using Products.Infrastructure.Configurations;

namespace Products.Infrastructure.Context;

public class ProductsContext : DbContext
{
    public const string DEFAULT_SCHEMA = "Products";

    public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
    {      
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<ExchangeRate> ExchangeRates { get; set; }
    public DbSet<Currency> Currencies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ExchangeRateEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new PriceEntityTypeConfiguration());      

        base.OnModelCreating(modelBuilder);
    }
}
