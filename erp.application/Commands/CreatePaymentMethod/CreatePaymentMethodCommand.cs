using erp.domain.Entities;
using erp.domain.Enumerators;
using MediatR;

namespace erp.application.Commands.CreatePaymentMethod;

public class CreatePaymentMethodCommand : IRequest<PaymentMethod>
{
    public PaymentMethodType Type { get; set; }
    public string Details { get; set; } = string.Empty;
}
