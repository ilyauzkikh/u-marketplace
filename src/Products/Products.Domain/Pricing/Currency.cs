using Products.Domain.BaseEntities;

namespace Products.Domain.Pricing;

public class Currency : Entity
{
    public Currency(CurrencyType type)
    {
        Type = type;
    }

    protected Currency() 
    { 
    }

    public CurrencyType Type { get; private set; }
}

public enum CurrencyType
{
    USD,
    EUR,
    PLN
}