using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations.User;

public class ReadUserRepository: ReadGenericRepository<Domain.Entities.Concrete.User>,Domain.Repository_Interfaces.User.IReadUserRepository
{
    public ReadUserRepository(StoreDb context) : base(context)
    {
    }
}