using Products.Domain.Entities;

namespace Products.Domain.PriceAggregate;

public class ExchangeRate : Entity
{
    public ExchangeRate(Currency first,
        Currency second,
        decimal firstToSecondRate,
        decimal secondToFirstRate)
    {
        First = first;
        Second = second;
        FirstToSecond = firstToSecondRate;
        SecondToFirst = secondToFirstRate;
    }

    public Currency First { get; private set; }
    public Currency Second { get; private set; }
    public decimal FirstToSecond { get; private set; }
    public decimal SecondToFirst { get; private set; }
}
