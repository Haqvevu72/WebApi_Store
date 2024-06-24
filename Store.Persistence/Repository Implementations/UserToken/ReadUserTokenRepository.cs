using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations.UserToken;

public class ReadUserTokenRepository: ReadGenericRepository<Domain.Entities.Concrete.UserToken>,Domain.Repository_Interfaces.UserToken.IReadUserTokenRepository
{
    public ReadUserTokenRepository(StoreDb context) : base(context)
    {
    }
}