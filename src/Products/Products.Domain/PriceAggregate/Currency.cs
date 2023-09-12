using Products.Domain.Entities;

namespace Products.Domain.PriceAggregate;

public class Currency : Entity
{
    public Currency(CurrencyType type,
        IEnumerable<ExchangeRate> exchangeRates)
    {
        Type = type;
        ExchangeRates = exchangeRates;
    }

    protected Currency() 
    { 
    }

    public CurrencyType Type { get; private set; }
    public IEnumerable<ExchangeRate> ExchangeRates { get; set; } 
}