using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.infra.Context;

namespace erp.infra.Repositories;

public class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    public CustomerRepository(AppDbContext db) : base(db)
    {
    }
}
