using erp.domain.Abstractions;
using MediatR;

namespace erp.application.Commands.DeleteProduct;

public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteProductCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var repo = _unitOfWork.ProductRepository;
        var existingProduct = await repo.GetById(request.Id);
        if (existingProduct is null)
            throw new KeyNotFoundException($"Product with Id {request.Id} does not exists");
        await repo.Delete(existingProduct.Id);
        await _unitOfWork.CommitAsync();
    }
}
