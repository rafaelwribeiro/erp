using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.domain.Enumerators;
using Mapster;
using MediatR;

namespace erp.application.Commands.CreateProduct;

internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
{
    
    private readonly IUnitOfWork _unitOfWork;
    private readonly IStockMovementService _stockMovementService;

    public CreateProductCommandHandler(IUnitOfWork unitOfWork, IStockMovementService stockMovementService)
    {
        _unitOfWork = unitOfWork;
        _stockMovementService = stockMovementService;
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
        await _stockMovementService.MoveStockAsync(product.Id, request.StockQuantity, request.Cost, StockMovementType.In, "Estoque inicial");
    }
}
