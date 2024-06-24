using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain;
using Store.Domain.Entities.Concrete;

namespace Store.Persistence.Configurations;

public class RoleConfiguration: IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasKey(r => r.Id);
        
        builder.HasData(
            new Role() { Id = 1,RoleType = RoleType.SuperAdmin, Description = "SuperAdmin can do everything" },
            new Role() { Id = 2,RoleType = RoleType.Admin , Description = "Admin"},
            new Role() { Id = 3,RoleType = RoleType.Cashier , Description = "Cashier"},
            new Role() { Id = 4,RoleType = RoleType.Customer , Description = "Customer"});
    }
}