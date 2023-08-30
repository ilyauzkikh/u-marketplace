using Products.Domain.Entities;

namespace Products.Domain.ProductAggregate;

public class Category : Entity
{
    public required string Title { get; set; }
    public required string Description { get; set; }
}