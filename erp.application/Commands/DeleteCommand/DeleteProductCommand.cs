using MediatR;

namespace erp.application.Commands.DeleteCommand;

public class DeleteProductCommand : IRequest
{
    public int Id { get; set; }
    public DeleteProductCommand(int id)
    {
        Id = id;
    }
}
