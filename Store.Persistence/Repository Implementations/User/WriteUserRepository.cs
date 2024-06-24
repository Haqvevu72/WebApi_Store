using Store.Domain.Repository_Interfaces.User;
using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations.User;

public class WriteUserRepository: WriteGenericRepository<Domain.Entities.Concrete.User> , IWriteUserRepository
{
    public WriteUserRepository(StoreDb context) : base(context)
    {
    }
}