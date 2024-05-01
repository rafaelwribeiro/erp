using erp.domain.Entities;
using MediatR;

namespace erp.application.Queries.ListStockMovements;

public class ListStockMovementsCommand : IRequest<IEnumerable<StockMovement>>
{
}
