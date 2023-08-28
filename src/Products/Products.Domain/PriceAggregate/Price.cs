using Products.Domain.Entities;

namespace Products.Domain.PriceAggregate;

public class Price : Entity
{
    public Price(Currency currency, decimal amount)
    {
        Currency = currency;
        Amount = amount;
    }

    public Currency Currency { get; set; }
    public decimal Amount { get; set; }

    public void ConvertTo(CurrencyType newCurrencyType)
    {
        Currency.Type = newCurrencyType;
        Amount *= Currency.ExchangeRates
            .FirstOrDefault(x => x.First == Currency.Type && x.Second == newCurrencyType)!
            .FirstToSecond;
    }
}
