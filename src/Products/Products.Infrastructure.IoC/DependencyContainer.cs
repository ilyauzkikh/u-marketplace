using Microsoft.Extensions.DependencyInjection;
using Products.Domain.Products;
using Products.Infrastructure.Repositories;

namespace Products.Infrastructure.IoC;

public static class DependencyContainer
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddTransient<IProductsRepository, ProductsRepository>();
    }
}
