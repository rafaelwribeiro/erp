using erp.domain.Entities;
using MediatR;

namespace erp.application.Queries.GetProduct;

public class GetProductQuery : IRequest<Product>
{
    public int Id { get; set; }
    public GetProductQuery()
    {
        
    }
    public GetProductQuery(int id)
    {
        Id = id;
    }
}
