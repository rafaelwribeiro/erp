using erp.domain.Abstractions;
using erp.domain.Entities;
using Mapster;
using MediatR;

namespace erp.application.Commands.CreateProduct;

internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
{
    
    private readonly IUnitOfWork _unitOfWork;

    public CreateProductCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var prodRepo = _unitOfWork.ProductRepository;


        var product = request.Adapt<Product>();
        product.Validate();

        await prodRepo.Add(product);
        await CreateStockMovement(request, product);

        await _unitOfWork.CommitAsync();

        return product;
    }

    private async Task CreateStockMovement(CreateProductCommand request, Product product)
    {
        if (request.StockQuantity <= 0) return;

        var stockRepo = _unitOfWork.StockMovementRepository;

        var stock = new StockMovement(product, request.StockQuantity, request.Cost, domain.Enumerators.StockMovementType.In, "Estoque inicial");

        await stockRepo.Add(stock);
    }
}
