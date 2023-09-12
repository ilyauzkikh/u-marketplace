using Products.Domain.Entities;

namespace Products.Domain.PriceAggregate;

public class Price : Entity
{
    public Price(Currency currency, decimal? amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(nameof(amount));

        BaseCurrency = currency;
        Amount = amount;
    }

    protected Price() { }

    public Currency BaseCurrency { get; private set; }
    public decimal? Amount { get; private set; }

    public void ChangeAmount(decimal newAmount)
    {
        if (newAmount < 0) throw new ArgumentOutOfRangeException(nameof (newAmount));
        Amount = newAmount;
    }

    public Price ConvertTo(Currency toCurrency)
    {
        var amount = Amount * BaseCurrency.ExchangeRates
            .FirstOrDefault(x => x.First == BaseCurrency.Type && x.Second == toCurrency.Type)!
            .FirstToSecond;

        return new Price(
            new Currency(toCurrency.Type, BaseCurrency.ExchangeRates),
            amount);
    }
}
