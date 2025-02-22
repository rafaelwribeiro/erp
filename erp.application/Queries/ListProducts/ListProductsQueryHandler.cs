using erp.domain.Abstractions;
using erp.domain.Entities;
using MediatR;

namespace erp.application.Queries.ListProducts;

public class ListProductsQueryHandler : IRequestHandler<ListProductsQuery, IEnumerable<Product>>
{
    private IProductRepository _repository;

    public ListProductsQueryHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Product>> Handle(ListProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await _repository.GetManyByFilter(p =>
            (string.IsNullOrEmpty(request.Name) || p.Name.Contains(request.Name)) &&
            (string.IsNullOrEmpty(request.Barcode) || p.BarCode.Contains(request.Barcode)) &&
            (request.Id == 0 || p.Id == request.Id)
        );
        
        return products;
    }
}

