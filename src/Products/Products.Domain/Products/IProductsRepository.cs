namespace Products.Domain.Products;

public interface IProductsRepository
{
    Task<Guid> AddProductAsync(Product product);
    Task<Product?> GetProductByIdAsync(Guid productId);
}
