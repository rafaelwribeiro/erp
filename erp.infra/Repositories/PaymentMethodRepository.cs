using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.infra.Context;

namespace erp.infra.Repositories;

public class PaymentMethodRepository : Repository<PaymentMethod>, IPaymentMethodRepository
{
    public PaymentMethodRepository(AppDbContext db) : base(db)
    {
    }
}
