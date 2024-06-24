using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Concrete;

namespace Store.Persistence.Configurations;

public class ProductConfiguration: IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasOne<Category>(p => p.Category)
               .WithMany(c => c.Products)
               .HasForeignKey(p => p.CategoryId);
        
        builder.HasData(
            new Product { Id = 1, Name = "Smartphone", Description = "Latest model smartphone", Price = 699.99m, StockQuantity = 50, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(2), Brand = "BrandA", CategoryId = 1 },
            new Product { Id = 2, Name = "Laptop", Description = "High performance laptop", Price = 999.99m, StockQuantity = 30, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(3), Brand = "BrandB", CategoryId = 1 },
            new Product { Id = 3, Name = "Headphones", Description = "Noise cancelling headphones", Price = 199.99m, StockQuantity = 100, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(1), Brand = "BrandC", CategoryId = 1 },
            new Product { Id = 4, Name = "Refrigerator", Description = "Energy efficient refrigerator", Price = 599.99m, StockQuantity = 20, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(5), Brand = "BrandD", CategoryId = 4 },
            new Product { Id = 5, Name = "Microwave", Description = "Compact microwave oven", Price = 99.99m, StockQuantity = 40, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(4), Brand = "BrandE", CategoryId = 4 },
            new Product { Id = 6, Name = "Running Shoes", Description = "Comfortable running shoes", Price = 49.99m, StockQuantity = 70, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(2), Brand = "BrandF", CategoryId = 5 },
            new Product { Id = 7, Name = "Treadmill", Description = "Foldable treadmill", Price = 499.99m, StockQuantity = 10, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(3), Brand = "BrandG", CategoryId = 5 },
            new Product { Id = 8, Name = "Action Figure", Description = "Collectible action figure", Price = 29.99m, StockQuantity = 200, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(1), Brand = "BrandH", CategoryId = 6 },
            new Product { Id = 9, Name = "Board Game", Description = "Fun family board game", Price = 39.99m, StockQuantity = 60, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(2), Brand = "BrandI", CategoryId = 6 },
            new Product { Id = 10, Name = "Lipstick", Description = "Long-lasting lipstick", Price = 9.99m, StockQuantity = 150, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddMonths(18), Brand = "BrandJ", CategoryId = 7 },
            new Product { Id = 11, Name = "Shampoo", Description = "Hair strengthening shampoo", Price = 5.99m, StockQuantity = 80, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddMonths(12), Brand = "BrandK", CategoryId = 7 },
            new Product { Id = 12, Name = "Car Battery", Description = "Long-life car battery", Price = 99.99m, StockQuantity = 25, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(5), Brand = "BrandL", CategoryId = 8 },
            new Product { Id = 13, Name = "Tire", Description = "All-season tire", Price = 79.99m, StockQuantity = 40, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(6), Brand = "BrandM", CategoryId = 8 },
            new Product { Id = 14, Name = "Coffee", Description = "Ground coffee", Price = 7.99m, StockQuantity = 100, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddMonths(6), Brand = "BrandN", CategoryId = 9 },
            new Product { Id = 15, Name = "Cereal", Description = "Breakfast cereal", Price = 3.99m, StockQuantity = 150, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddMonths(12), Brand = "BrandO", CategoryId = 9 },
            new Product { Id = 16, Name = "Office Chair", Description = "Ergonomic office chair", Price = 149.99m, StockQuantity = 20, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(10), Brand = "BrandP", CategoryId = 10 },
            new Product { Id = 17, Name = "Dining Table", Description = "Wooden dining table", Price = 299.99m, StockQuantity = 15, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(15), Brand = "BrandQ", CategoryId = 10 },
            new Product { Id = 18, Name = "Smart Watch", Description = "Fitness tracking smart watch", Price = 199.99m, StockQuantity = 35, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(2), Brand = "BrandR", CategoryId = 1 },
            new Product { Id = 19, Name = "E-book Reader", Description = "Portable e-book reader", Price = 129.99m, StockQuantity = 50, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(3), Brand = "BrandS", CategoryId = 2 },
            new Product { Id = 20, Name = "Sweater", Description = "Warm woolen sweater", Price = 49.99m, StockQuantity = 60, BarCode = Guid.NewGuid(), ExpireDate = DateTime.Now.AddYears(2), Brand = "BrandT", CategoryId = 3 }
        );
    }
}