using Products.Domain.CustomerAggregate;
using Products.Domain.PriceAggregate;
using Products.Domain.ProductAggregate;

namespace Products.UnitTests.Products.Domain.Tests;

public class ProductTests
{
    private Customer _testCustomer => new Customer("Ilya", "Uzkikh", "+48111222333");
    private Currency _testCurrency => new Currency(CurrencyType.USD, new ExchangeRate[]
        {
            new ExchangeRate(CurrencyType.USD, CurrencyType.PLN, 4, 1 / 4)
        });

    private static Product CreateTestProduct(Currency currency, Customer owner)
    {
        string title = "Test Product";
        string description = "Test Description";
        var category = new Category { Title = "Test Category Title", Description = "Test Category Description" };
        var price = new Price(currency, 1000);

        return new Product(title,
            description,
            category,
            price,
            owner);
    }

    [Fact]
    public void Product_SuccessfullyCreates()
    {
        //Arrange
        Currency category = _testCurrency;
        Customer owner = _testCustomer;

        //Act
        var product = CreateTestProduct(category, owner);

        //Assert
        Assert.NotNull(product);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void Product_ChangeTitle_ThrowsExceptionIfTitleNullOrEmpty(string title)
    {
        //Arrange
        var product = CreateTestProduct(_testCurrency, _testCustomer);

        //Act
        try
        {
            product.ChangeTitle(title);
        }
        catch (Exception e)
        {
            //Assert
            Assert.Equal(typeof(ArgumentNullException), e.GetType());
        }             
    }
}
