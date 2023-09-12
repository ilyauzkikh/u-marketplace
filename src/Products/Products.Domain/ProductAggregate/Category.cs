using Products.Domain.Entities;

namespace Products.Domain.ProductAggregate;

public class Category : Entity
{
    protected Category() { }

    public Category(Category? parent = null)
    {
        Parent = parent;
    }

    public Category? Parent { get; private set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
}