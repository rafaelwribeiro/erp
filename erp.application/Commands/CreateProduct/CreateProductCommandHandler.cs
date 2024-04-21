using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.domain.Exceptions;
using Mapster;
using MediatR;

namespace erp.application.Commands.CreateProduct;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
{
    
    private readonly IUnitOfWork _unitOfWork;

    public CreateProductCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var prodRepo = _unitOfWork.ProductRepository;

        Validate(request);

        var product = request.Adapt<Product>();

        await prodRepo.Add(product);
        await _unitOfWork.CommitAsync();

        return product;
    }

    private void Validate(CreateProductCommand request)
    {
        if (string.IsNullOrEmpty(request.Name))
            throw new BusinessRuleException("Name must be informed");
        
        if (request.Price < 0)
            throw new BusinessRuleException("Price must be greater then Zero.");
        
        if (request.StockQuantity < 0)
            throw new BusinessRuleException("Stock Quantity must be greater then Zero.");

    }
}
