using erp.domain.Abstractions;
using erp.domain.Entities;
using Mapster;
using MediatR;

namespace erp.application.Commands.CreateCustomer;

internal class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Customer>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateCustomerCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var customer = request.Adapt<Customer>();
        customer.Validate();

        var repo = _unitOfWork.CustomerRepository;

        customer = await repo.Add(customer);

        await _unitOfWork.CommitAsync();

        return customer;
    }
}
