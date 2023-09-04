using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Products.Domain.CustomerAggregate;
using Products.Domain.PriceAggregate;
using Products.Domain.ProductAggregate;
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
        modelBuilder.ApplyConfiguration(new CategoryEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ExchangeRateEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CurrencyEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new PriceEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
    }
}

public class ProductsContextDesignFactory : IDesignTimeDbContextFactory<ProductsContext>
{
    public ProductsContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ProductsContext>()
            .UseSqlServer(args[0]);

        return new ProductsContext(optionsBuilder.Options);
    }
}
