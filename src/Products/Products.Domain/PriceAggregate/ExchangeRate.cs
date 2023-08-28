namespace Products.Domain.PriceAggregate;

public class ExchangeRate
{
    public CurrencyType First { get; private set; }
    public CurrencyType Second { get; private set; }
    public decimal FirstToSecond { get; private set; }
    public decimal SecondToFirst { get; private set; }
}
