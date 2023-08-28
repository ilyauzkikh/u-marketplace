using Products.Domain.Entities;

namespace Products.Domain.ProductsAggregate;

public class Category : ValueObject
{
    public required string Title { get; set; }
    public required string Description { get; set; }
}