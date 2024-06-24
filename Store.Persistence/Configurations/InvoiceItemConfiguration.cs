using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Concrete;

namespace Store.Persistence.Configurations;

public class InvoiceItemConfiguration: IEntityTypeConfiguration<InvoiceItem>
{
    public void Configure(EntityTypeBuilder<InvoiceItem> builder)
    {
        builder.HasKey(ii => ii.Id);

        builder.HasOne<Product>(ii => ii.Product)
               .WithMany(p => p.InvoiceItems)
               .HasForeignKey(ii => ii.ProductId);

        builder.HasOne<Invoice>()
               .WithMany(i => i.InvoiceItems)
               .HasForeignKey("Invoice_FK");

    }
}