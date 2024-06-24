using Store.Domain.Repository_Interfaces.UserToken;
using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations.UserToken;

public class WriteUserTokenRepository: WriteGenericRepository<Domain.Entities.Concrete.UserToken>,IWriteUserTokenRepository
{
    public WriteUserTokenRepository(StoreDb context) : base(context)
    {
    }
}