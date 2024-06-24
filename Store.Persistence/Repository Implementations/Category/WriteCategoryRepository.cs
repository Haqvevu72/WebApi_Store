using Store.Domain.Repository_Interfaces.Category;
using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations.Category;

public class WriteCategoryRepository: WriteGenericRepository<Domain.Entities.Concrete.Category> , IWriteCategoryRepository
{
    public WriteCategoryRepository(StoreDb context) : base(context)
    {
    }
}