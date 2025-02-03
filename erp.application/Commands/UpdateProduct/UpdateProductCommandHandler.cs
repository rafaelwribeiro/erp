using erp.domain.Abstractions;
using Mapster;
using MediatR;

namespace erp.application.Commands.UpdateProduct;

internal class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
{
    private readonly IUnitOfWork _unitOfWork;
    public UpdateProductCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var repo = _unitOfWork.ProductRepository;

        var existingProduct = await repo.GetById(request.Id);
        if (existingProduct is null)
            throw new KeyNotFoundException($"Product with Id {request.Id} does not exists");

        request.Adapt(existingProduct);

        existingProduct.Validate();

        existingProduct.UpdatedAt = DateTime.Now;

        repo.Update(existingProduct);

        await _unitOfWork.CommitAsync();
    }
}
