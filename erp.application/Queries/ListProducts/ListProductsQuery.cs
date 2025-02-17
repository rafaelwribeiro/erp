using erp.domain.Entities;
using MediatR;

namespace erp.application.Queries.ListProducts;

public class ListProductsQuery : IRequest<IEnumerable<Product>>
{
    public int Id { get; set; } = 0;
    public string? Name { get; set; } = string.Empty;
}
