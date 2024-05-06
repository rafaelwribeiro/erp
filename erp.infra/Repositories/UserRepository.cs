using erp.domain.Abstractions;
using erp.domain.Entities;
using erp.infra.Context;

namespace erp.infra.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(AppDbContext db) : base(db)
    {
    }
}
