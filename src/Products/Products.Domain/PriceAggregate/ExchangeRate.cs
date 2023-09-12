using Products.Domain.Entities;

namespace Products.Domain.PriceAggregate;

public class ExchangeRate : Entity
{
    public ExchangeRate(CurrencyType first,
        CurrencyType second,
        decimal firstToSecondRate,
        decimal secondToFirstRate)
    {
        First = first;
        Second = second;
        FirstToSecond = firstToSecondRate;
        SecondToFirst = secondToFirstRate;

        Currencies = new HashSet<Currency>();
    }

    protected ExchangeRate() { }

    public CurrencyType First { get; private set; }
    public CurrencyType Second { get; private set; }
    public decimal FirstToSecond { get; private set; }
    public decimal SecondToFirst { get; private set; }

    public virtual IEnumerable<Currency> Currencies { get; set; }
}
