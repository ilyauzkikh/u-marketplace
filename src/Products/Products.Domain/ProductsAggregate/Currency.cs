namespace Products.Domain.ProductsAggregate;

public enum CurrencyName
{
    USD,
    EUR,
    PLN
}

public class ExchangeRate
{
    public CurrencyName First { get; private set; }
    public CurrencyName Second { get; private set; }
    public decimal FirstToSecond { get; private set; }
    public decimal SecondToFirst { get; private set; }
}

public class Currency
{
    public Currency(CurrencyName name,
        decimal amount,
        IEnumerable<ExchangeRate> exchangeRates)
    {
        Name = name;
        Amount = amount;
        ExchangeRates = exchangeRates;
    }
    
    public CurrencyName Name { get; private set; }
    public decimal Amount { get; private set; }
    public IEnumerable<ExchangeRate> ExchangeRates { get; private set; }
    
    public void ConvertTo(CurrencyName newName)
    {
        Name = newName;
        Amount = Amount * ExchangeRates
            .FirstOrDefault(x => x.First == Name && x.Second == newName)!
            .FirstToSecond;
    }
}