using Store.Domain.Repository_Interfaces.InvoiceItems;
using Store.Persistence.Database;

namespace Store.Persistence.Repository_Implementations.InvoiceItem;

public class ReadInvoiceItemRepository: ReadGenericRepository<Domain.Entities.Concrete.InvoiceItem> , IReadInvoiceItemRepository
{
    public ReadInvoiceItemRepository(StoreDb context) : base(context)
    {
    }
}