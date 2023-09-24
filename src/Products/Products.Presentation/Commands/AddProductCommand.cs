using MediatR;

namespace Products.Presentation.Commands;

public class AddProductCommand : IRequest<Guid>
{
    public AddProductCommand(string title,
        string description,
        Guid categoryId,
        int currencyType,
        decimal priceAmount,
        Guid ownerId)
    {
        Title = title;
        Description = description;
        CategoryId = categoryId;
        CurrencyType = currencyType;
        PriceAmount = priceAmount;
        OwnerId = ownerId;
    }


    public string Title { get; private set; }
    public string Description { get; private set; }
    public Guid CategoryId { get; private set; }
    public int CurrencyType { get; private set; }
    public decimal PriceAmount { get; private set; }
    public Guid OwnerId { get; private set; }
}
