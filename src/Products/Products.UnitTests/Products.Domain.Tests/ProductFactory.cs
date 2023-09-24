using Products.Domain.Customers;
using Products.Domain.Pricing;
using Products.Domain.Products;

namespace Products.UnitTests.Products.Domain.Tests;

public static class ProductFactory
{
    public static Customer TestCustomer { get; } = new Customer("Ilya", "Uzkikh", "+48111222333", "test@mail.com");
    public static Currency TestCurrency { get; } = new Currency(CurrencyType.USD);

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
