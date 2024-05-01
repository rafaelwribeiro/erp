using MediatR;

namespace erp.application.Commands.DeleteProduct;

public class DeleteProductCommand : IRequest
{
    public int Id { get; set; }
    public DeleteProductCommand(int id)
    {
        Id = id;
    }
}
