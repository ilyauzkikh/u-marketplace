﻿using Products.Domain.CustomerAggregate;
using Products.Domain.PriceAggregate;
using Products.Domain.ProductAggregate;

namespace Products.UnitTests.Products.Domain.Tests;

public static class ProductFactory
{
    public static Customer TestCustomer => new Customer("Ilya", "Uzkikh", "+48111222333");
    public static Currency TestCurrency => new Currency(CurrencyType.USD, new ExchangeRate[]
    {
        new ExchangeRate(CurrencyType.USD, CurrencyType.PLN, 4, 1 / 4)
    });

    public static Product Create(Customer owner, decimal priceAmount)
    {
        string title = "Test Product";
        string description = "Test Description";
        var category = new Category { Title = "Test Category Title", Description = "Test Category Description" };
        var price = new Price(TestCurrency, priceAmount);

        return new Product(title,
            description,
            category,
            price,
            owner);
    }
}