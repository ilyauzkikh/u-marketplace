﻿using Products.Domain.Customers;
using Products.Domain.BaseEntities;
using Products.Domain.Pricing;

namespace Products.Domain.Products;

public class Product : Entity, IAggregateRoot
{
    protected Product() {}

    public Product(string title,
        string description,
        Category category,
        Price price,
        Customer owner)
    {
        Title = title;
        Description = description;
        Category = category;
        Price = price;
        Owner = owner;
    }

    public string Title { get; private set; }
    public string Description { get; private set; }
    public Category Category { get; private set; }
    public Price Price { get; private set; }
    public Customer Owner { get; private set; }

    public bool IsGiveAway => Price.Amount == 0;

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

    public void ChangePriceAmount(decimal newAmount)
    {
        Price.ChangeAmount(newAmount);
    }
}