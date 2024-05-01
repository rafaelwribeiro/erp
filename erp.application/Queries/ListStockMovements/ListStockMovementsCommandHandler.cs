using erp.domain.Abstractions;
using erp.domain.Entities;
using MediatR;

namespace erp.application.Queries.ListStockMovements;

public class ListStockMovementsCommandHandler : IRequestHandler<ListStockMovementsCommand, IEnumerable<StockMovement>>
{
    private readonly IUnitOfWork _unitOfWork;

    public ListStockMovementsCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<StockMovement>> Handle(ListStockMovementsCommand request, CancellationToken cancellationToken)
    {
        var repo = _unitOfWork.StockMovementRepository;

        return await repo.GetAll();
    }
}
