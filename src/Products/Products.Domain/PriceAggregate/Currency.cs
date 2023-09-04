using Products.Domain.Entities;

namespace Products.Domain.PriceAggregate;

public class Currency : ValueObject
{
    public Currency(CurrencyType type,
        IEnumerable<ExchangeRate> exchangeRates)
    {
        Type = type;
        ExchangeRates = exchangeRates;
    }

    public CurrencyType Type { get; set; }
    public IEnumerable<ExchangeRate> ExchangeRates { get; private set; }
}