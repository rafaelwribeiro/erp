using erp.domain.Entities;
using erp.domain.Enumerators;
using MediatR;

namespace erp.application.Commands.NewStockMovement;

public class NewStockMovementCommand : IRequest<StockMovement>
{
    public int ProductId { get; set; }
    public int Amount { get; set; }
    public StockMovementType Type { get; set; } = StockMovementType.In;
    public string Description { get; set; } = string.Empty;
}
