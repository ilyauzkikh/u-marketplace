using Products.Domain.BaseEntities;

namespace Products.Domain.Products;

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