using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Concrete;

namespace Store.Persistence.Configurations;

public class InvoiceConfiguration: IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.HasKey(i => i.Id);

        builder.HasOne<User>(i => i.Cashier)
               .WithMany(c => c.CashierInvoices)
               .HasForeignKey(i => i.CashierId);

        builder.HasOne<User>(i => i.Customer)
            .WithMany(c => c.CustomerInvoices)
            .HasForeignKey(i => i.CustomerId);
    }
}