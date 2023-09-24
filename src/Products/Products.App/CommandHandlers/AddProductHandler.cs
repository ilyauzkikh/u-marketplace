using MediatR;
using Products.Domain.Products;
using Products.Presentation.Commands;

namespace Products.App.CommandHandlers;

public class AddProductHandler : IRequestHandler<AddProductCommand, Guid>
{
    private readonly IProductsRepository _productsRepository;

    public AddProductHandler(IProductsRepository productsRepository)
    {
        _productsRepository = productsRepository;
    }

    public Task<Guid> Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product(request.Title, request.Description, );
        throw new NotImplementedException();
    }
}
