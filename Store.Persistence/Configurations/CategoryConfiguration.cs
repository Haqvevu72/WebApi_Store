using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities.Concrete;

namespace Store.Persistence.Configurations;

public class CategoryConfiguration: IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);
        
        builder.HasData(
            new Category { Id = 1, Name = "Electronics", Description = "Devices and gadgets" },
            new Category { Id = 2, Name = "Books", Description = "Printed and electronic books" },
            new Category { Id = 3, Name = "Clothing", Description = "Men's and women's clothing" },
            new Category { Id = 4, Name = "Home Appliances", Description = "Kitchen and home appliances" },
            new Category { Id = 5, Name = "Sports", Description = "Sporting goods and equipment" },
            new Category { Id = 6, Name = "Toys", Description = "Toys and games for children" },
            new Category { Id = 7, Name = "Beauty", Description = "Beauty and personal care products" },
            new Category { Id = 8, Name = "Automotive", Description = "Car parts and accessories" },
            new Category { Id = 9, Name = "Groceries", Description = "Food and beverages" },
            new Category { Id = 10, Name = "Furniture", Description = "Home and office furniture" }
            );
    }
}