using Store.Domain.Repository_Interfaces.Role;
using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations.Role;

public class ReadRoleRepository: ReadGenericRepository<Domain.Entities.Concrete.Role> , IReadRoleRepository
{
    public ReadRoleRepository(StoreDb context) : base(context)
    {
    }
}