namespace Products.Domain.Pricing;

public class PriceConverter
{
    private readonly Price _currentPrice;
    private readonly IEnumerable<ExchangeRate> _exchangeRates;

    public PriceConverter(Price currentPrice, IEnumerable<ExchangeRate> exchangeRates)
    {
        _currentPrice = currentPrice;
        _exchangeRates = exchangeRates;
    }

    public Price ConvertTo(Currency newCurrency)
    {
        if (_currentPrice.BaseCurrency == newCurrency)
        {
            throw new ArgumentException($"Price's currency is already {nameof(newCurrency)}.");
        }

        var exchangeRate = _exchangeRates.FirstOrDefault(x => x.First == _currentPrice.BaseCurrency.Type)?.FirstToSecond;
        return new Price(newCurrency, _currentPrice.Amount * exchangeRate);
    }
}
