using Store.Domain.Repository_Interfaces.Role;
using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations.Role;

public class WriteRoleRepository: WriteGenericRepository<Domain.Entities.Concrete.Role> , IWriteRoleRepository
{
    public WriteRoleRepository(StoreDb context) : base(context)
    {
    }
}