﻿using Products.Domain.Customers;
using Products.Domain.Pricing;
using FluentAssertions;

namespace Products.UnitTests.Products.Domain.Tests;

public class ProductTests
{    
    [Fact]
    public void Product_SuccessfullyCreates()
    {
        //Arrange
        Customer owner = ProductFactory.TestCustomer;

        //Act
        var product = ProductFactory.Create(owner, 1000);

        //Assert
        product.Should().NotBeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void Product_ChangeTitle_ThrowsExceptionIfTitleNullOrEmpty(string title)
    {
        //Arrange
        var product = ProductFactory.Create(ProductFactory.TestCustomer, 1000);

        //Act
        try
        {
            product.ChangeTitle(title);
        }
        catch (Exception e)
        {
            //Assert
            e.Should().BeOfType<ArgumentNullException>();
        }             
    }

    [Theory]
    [InlineData("TestTitleChanged")]
    public void Product_ChangesTitle_Successfully_IfStringHasValue(string title)
    {
        //Arrange
        var product = ProductFactory.Create(ProductFactory.TestCustomer, 1000);

        //Act
        product.ChangeTitle(title);

        //Arrage
        product.Title.Should().BeEquivalentTo(title);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void Product_ChangeDesc_ThrowsExceptionIfTitleNullOrEmpty(string description)
    {
        //Arrange
        var product = ProductFactory.Create(ProductFactory.TestCustomer, 1000);

        //Act
        try
        {
            product.ChangeDescription(description);
        }
        catch (Exception e)
        {
            //Assert
            e.Should().BeOfType<ArgumentNullException>();
        }
    }

    [Theory]
    [InlineData("TestDescriptionChanged")]
    public void Product_ChangesDesc_Successfully_IfStringHasValue(string description)
    {
        //Arrange
        var product = ProductFactory.Create(ProductFactory.TestCustomer, 1000);

        //Act
        product.ChangeDescription(description);

        //Assert
        product.Description.Should().BeEquivalentTo(description);
    }

    [Theory]
    [InlineData(100)]
    [InlineData(0.0001)]
    public void ProductPrice_IsValid_IfAmountIsGreaterThenZero(decimal amount)
    {
        //Arrange, Act
        var product = ProductFactory.Create(ProductFactory.TestCustomer, amount);

        //Assert
        product.Price.Should().NotBeNull();
    }

    [Theory]
    [InlineData(-5)]
    public void ProductPrice_ThrowsException_IfAmountIsLessThenZero(decimal amount)
    {
        try
        {
            //Arrange, Act
            var product = ProductFactory.Create(ProductFactory.TestCustomer, amount);           
        }
        catch (Exception e)
        {
            //Assert\
            e.Should().BeOfType<ArgumentOutOfRangeException>();
        }
    }

    [Theory]
    [InlineData(-5)]
    public void Product_ChangePriceAmount_ThrowsExceptions_IfAmountIsLessThenZero(decimal amount)
    {
        //Arrange
        var product = ProductFactory.Create(ProductFactory.TestCustomer, 1000);

        try
        {
            //Act
            product.ChangePriceAmount(amount);
        }
        catch (Exception e)
        {
            //Assert
            e.Should().BeOfType<ArgumentOutOfRangeException>();
        }
    }
}
