using Store.Domain.Repository_Interfaces.Category;
using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations.Category;

public class ReadCategoryRepository: ReadGenericRepository<Domain.Entities.Concrete.Category>, IReadCategoryRepository
{
    public ReadCategoryRepository(StoreDb context) : base(context)
    {
    }
}