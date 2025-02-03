using erp.domain.Abstractions;
using erp.domain.Entities;
using MediatR;

namespace erp.application.Commands.NewStockMovement;

public class NewStockMovementCommandHandler : IRequestHandler<NewStockMovementCommand, StockMovement>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IStockMovementService _stockMovementService;

    public NewStockMovementCommandHandler(IUnitOfWork unitOfWork, IStockMovementService stockMovementService)
    {
        _unitOfWork = unitOfWork;
        _stockMovementService = stockMovementService;
    }

    public async Task<StockMovement> Handle(NewStockMovementCommand request, CancellationToken cancellationToken)
    {
        var newMovement = await _stockMovementService.MoveStockAsync(request.ProductId, request.Amount, request.UnitValue, request.Type, request.Description);

        await _unitOfWork.CommitAsync();

        return newMovement;
    }
}
