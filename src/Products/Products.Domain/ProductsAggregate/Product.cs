using Products.Domain.Entities;
using Products.Domain.PriceAggregate;

namespace Products.Domain.ProductsAggregate;

public class Product : TrackableEntity
{
    protected Product() {}

    public Product(string title,
        string description,
        Category category,
        Price price)
    {
        Title = title;
        Description = description;
        Category = category;
        Price = price;
    }

    public string Title { get; private set; }
    public string Description { get; private set; }
    public Category Category { get; private set; }
    public Price Price { get; private set; }

    public void ChangeTitle(string newTitle)
    {
        if (string.IsNullOrEmpty(newTitle))
            throw new ArgumentNullException(nameof(newTitle));

        Title = newTitle;
    }

    public void ChangeDescription(string newDescription)
    {
        if (string.IsNullOrEmpty((newDescription)))
            throw new ArgumentNullException(nameof(newDescription));

        Description = newDescription;
    }
}