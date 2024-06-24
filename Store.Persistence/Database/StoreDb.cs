using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities.Abstract;
using Store.Domain.Entities.Concrete;
using Store.Persistence.Configurations;

namespace Store.Persistence.Database;

public class StoreDb: DbContext
{
    public StoreDb(DbContextOptions<StoreDb> options): base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
        modelBuilder.ApplyConfiguration(new InvoiceItemConfiguration());
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        base.OnModelCreating(modelBuilder);
    }

    // SaveChange
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var datas = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified || x.State == EntityState.Added);

        foreach (var item in datas)
        {
            if (item.Entity is BaseEntity entity)
            {
                if (item.State == EntityState.Added)
                    entity.CreatedAt = DateTime.Now;
                entity.UpdatedAt = DateTime.Now;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
    
    // Tables
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Invoice> Invoices { get; set; }
    public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<UserToken> UserTokens { get; set; }
    
}