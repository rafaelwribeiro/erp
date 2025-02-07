using erp.domain.Abstractions;
using erp.domain.Entities;
using Mapster;
using MediatR;

namespace erp.application.Commands.CreatePaymentMethod;

internal class CreatePaymentMethodCommandHandler : IRequestHandler<CreatePaymentMethodCommand, PaymentMethod>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreatePaymentMethodCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<PaymentMethod> Handle(CreatePaymentMethodCommand request, CancellationToken cancellationToken)
    {
        var repo = _unitOfWork.PaymentMethodRepository;
        var paymentMethod = request.Adapt<PaymentMethod>();

        await repo.Add(paymentMethod);
        await _unitOfWork.CommitAsync();
        return paymentMethod;
    }
}
