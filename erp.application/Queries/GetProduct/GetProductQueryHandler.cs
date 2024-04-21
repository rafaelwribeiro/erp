using erp.domain.Abstractions;
using erp.domain.Entities;
using MediatR;

namespace erp.application.Queries.GetProduct;

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, Product>
{
    private IProductRepository _repository;

    public GetProductQueryHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var product = await _repository.GetById(request.Id);

        if (product == null)
            throw new KeyNotFoundException("Product not found");
        
        return product;
    }
}
