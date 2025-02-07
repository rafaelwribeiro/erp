using erp.domain.Enumerators;

namespace erp.domain.Entities;

public class PaymentMethod : Entity
{
    public PaymentMethodType Type { get; set; }
    public string Details { get; set; } = string.Empty;
}