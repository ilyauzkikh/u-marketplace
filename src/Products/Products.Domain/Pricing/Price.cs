using Products.Domain.BaseEntities;

namespace Products.Domain.Pricing;

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
}
