using Microsoft.EntityFrameworkCore;
using Products.Domain.BaseEntities;
using Products.Domain.Products;

namespace Products.Infrastructure.Repositories;

public class ProductsRepository : IProductsRepository
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductsRepository(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Guid> AddProductAsync(Product product)
    {
        var table = _unitOfWork.Set<Product>();
        table.Add(product);

        await _context.SaveChangesAsync();
        return product.Id;
    }

    public async Task<Product?> GetProductByIdAsync(Guid productId)
    {
        var table = _context.Set<Product>();
        return await table.FirstOrDefaultAsync(x => x.Id == productId);
    }
}
