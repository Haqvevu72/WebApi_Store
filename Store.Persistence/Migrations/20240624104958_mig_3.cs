using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Store.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5410), "Devices and gadgets", false, "Electronics", new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5410) },
                    { 2, new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420), "Printed and electronic books", false, "Books", new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420) },
                    { 3, new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420), "Men's and women's clothing", false, "Clothing", new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420) },
                    { 4, new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420), "Kitchen and home appliances", false, "Home Appliances", new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420) },
                    { 5, new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420), "Sporting goods and equipment", false, "Sports", new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420) },
                    { 6, new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420), "Toys and games for children", false, "Toys", new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420) },
                    { 7, new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420), "Beauty and personal care products", false, "Beauty", new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420) },
                    { 8, new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420), "Car parts and accessories", false, "Automotive", new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420) },
                    { 9, new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420), "Food and beverages", false, "Groceries", new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420) },
                    { 10, new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420), "Home and office furniture", false, "Furniture", new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5420) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5220), new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5220), new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5220), new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5220), new DateTime(2024, 6, 24, 10, 49, 58, 225, DateTimeKind.Utc).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "Name", "Password", "RoleId", "Surname", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6420), "john.doe@example.com", "John", "Password1", 2, "Doe", new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6420) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "RoleId", "Surname", "TokenId", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6430), "jane.smith@example.com", false, "Jane", "Password2", 3, "Smith", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6430) },
                    { 3, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6430), "jim.beam@example.com", false, "Jim", "Password3", 4, "Beam", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6430) },
                    { 4, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6430), "jack.daniels@example.com", false, "Jack", "Password4", 2, "Daniels", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6430) },
                    { 5, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6430), "jill.valentine@example.com", false, "Jill", "Password5", 3, "Valentine", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6430) },
                    { 6, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6430), "jake.gyllenhaal@example.com", false, "Jake", "Password6", 4, "Gyllenhaal", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6430) },
                    { 7, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6430), "jessica.jones@example.com", false, "Jessica", "Password7", 2, "Jones", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6430) },
                    { 8, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440), "james.bond@example.com", false, "James", "Password8", 3, "Bond", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440) },
                    { 9, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440), "bruce.wayne@example.com", false, "Bruce", "Password9", 4, "Wayne", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440) },
                    { 10, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440), "clark.kent@example.com", false, "Clark", "Password10", 2, "Kent", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440) },
                    { 11, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440), "peter.parker@example.com", false, "Peter", "Password11", 3, "Parker", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440) },
                    { 12, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440), "tony.stark@example.com", false, "Tony", "Password12", 4, "Stark", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440) },
                    { 13, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440), "steve.rogers@example.com", false, "Steve", "Password13", 2, "Rogers", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440) },
                    { 14, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440), "natasha.romanoff@example.com", false, "Natasha", "Password14", 3, "Romanoff", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440) },
                    { 15, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440), "wanda.maximoff@example.com", false, "Wanda", "Password15", 4, "Maximoff", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440) },
                    { 16, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6440), "bruce.banner@example.com", false, "Bruce", "Password16", 2, "Banner", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6450) },
                    { 17, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6450), "stephen.strange@example.com", false, "Stephen", "Password17", 3, "Strange", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6450) },
                    { 18, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6450), "scott.lang@example.com", false, "Scott", "Password18", 4, "Lang", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6450) },
                    { 19, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6450), "sam.wilson@example.com", false, "Sam", "Password19", 2, "Wilson", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6450) },
                    { 20, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6450), "bucky.barnes@example.com", false, "Bucky", "Password20", 3, "Barnes", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6450) },
                    { 21, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6450), "Elgun02@gmail.com", false, "Elgun", "Elgun123", 1, "Haqverdiyev", null, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(6450) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "Brand", "CategoryId", "CreatedAt", "Description", "ExpireDate", "IsDeleted", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new Guid("10f00424-41b6-4e7b-b9e9-6469b895c198"), "BrandA", 1, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4770), "Latest model smartphone", new DateTime(2026, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(4830), false, "Smartphone", 699.99m, 50, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4780) },
                    { 2, new Guid("f4c3f536-8254-4333-aa4a-cff7ded2b37a"), "BrandB", 1, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4880), "High performance laptop", new DateTime(2027, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(4890), false, "Laptop", 999.99m, 30, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4880) },
                    { 3, new Guid("11c1859b-f96f-49e6-803c-3cd46cc07406"), "BrandC", 1, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4890), "Noise cancelling headphones", new DateTime(2025, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(4900), false, "Headphones", 199.99m, 100, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4890) },
                    { 4, new Guid("161d0130-3722-4527-879d-b51a8ff6d036"), "BrandD", 4, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4900), "Energy efficient refrigerator", new DateTime(2029, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(4910), false, "Refrigerator", 599.99m, 20, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4900) },
                    { 5, new Guid("38f53792-f8ac-4f92-87af-6a188884773b"), "BrandE", 4, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4910), "Compact microwave oven", new DateTime(2028, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(4920), false, "Microwave", 99.99m, 40, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4910) },
                    { 6, new Guid("eb7c8cd5-ddd1-4d46-9e26-34ffca4dfc11"), "BrandF", 5, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4920), "Comfortable running shoes", new DateTime(2026, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(4930), false, "Running Shoes", 49.99m, 70, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4920) },
                    { 7, new Guid("73a4d56f-83bc-4bf8-bfe6-c70fec74f16d"), "BrandG", 5, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4930), "Foldable treadmill", new DateTime(2027, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(4940), false, "Treadmill", 499.99m, 10, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4930) },
                    { 8, new Guid("3d838bed-0a98-4109-8655-857b49b12726"), "BrandH", 6, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4940), "Collectible action figure", new DateTime(2025, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(4940), false, "Action Figure", 29.99m, 200, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4940) },
                    { 9, new Guid("5a9e3efe-3f36-41e2-b8f6-32d43f2e4981"), "BrandI", 6, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4950), "Fun family board game", new DateTime(2026, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(4950), false, "Board Game", 39.99m, 60, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4950) },
                    { 10, new Guid("c3f50eca-39d5-4490-b1bc-1a04b13359d7"), "BrandJ", 7, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4960), "Long-lasting lipstick", new DateTime(2025, 12, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(4960), false, "Lipstick", 9.99m, 150, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4960) },
                    { 11, new Guid("5979c365-8fe5-476c-b325-7e93196ab99a"), "BrandK", 7, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4970), "Hair strengthening shampoo", new DateTime(2025, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(4970), false, "Shampoo", 5.99m, 80, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4970) },
                    { 12, new Guid("d6eef7fa-0487-40d1-bbb0-4f38f6945fb7"), "BrandL", 8, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4970), "Long-life car battery", new DateTime(2029, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(4980), false, "Car Battery", 99.99m, 25, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4970) },
                    { 13, new Guid("59881875-b418-4826-9c40-5380b7ada135"), "BrandM", 8, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4980), "All-season tire", new DateTime(2030, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(4990), false, "Tire", 79.99m, 40, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4980) },
                    { 14, new Guid("ab654376-7a1b-4044-93ee-45749d042123"), "BrandN", 9, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4990), "Ground coffee", new DateTime(2024, 12, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(5000), false, "Coffee", 7.99m, 100, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(4990) },
                    { 15, new Guid("ab1b8273-dd1a-4cc6-99ec-8db80cba30a6"), "BrandO", 9, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(5000), "Breakfast cereal", new DateTime(2025, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(5010), false, "Cereal", 3.99m, 150, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(5000) },
                    { 16, new Guid("d452dba8-664e-4105-93f2-d3f966c8379a"), "BrandP", 10, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(5010), "Ergonomic office chair", new DateTime(2034, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(5020), false, "Office Chair", 149.99m, 20, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(5010) },
                    { 17, new Guid("04018484-e563-4935-818e-670fe5b54afa"), "BrandQ", 10, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(5020), "Wooden dining table", new DateTime(2039, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(5020), false, "Dining Table", 299.99m, 15, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(5020) },
                    { 18, new Guid("efac6d5d-6236-4cc8-b6e1-501cdde8ef62"), "BrandR", 1, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(5030), "Fitness tracking smart watch", new DateTime(2026, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(5030), false, "Smart Watch", 199.99m, 35, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(5030) },
                    { 19, new Guid("142fc708-8e24-45aa-8acc-9bcd79f8e40a"), "BrandS", 2, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(5040), "Portable e-book reader", new DateTime(2027, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(5040), false, "E-book Reader", 129.99m, 50, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(5040) },
                    { 20, new Guid("26a8d0a2-e3aa-4f94-9bfc-0dff6b4e1b52"), "BrandT", 3, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(5040), "Warm woolen sweater", new DateTime(2026, 6, 24, 14, 49, 58, 223, DateTimeKind.Local).AddTicks(5050), false, "Sweater", 49.99m, 60, new DateTime(2024, 6, 24, 10, 49, 58, 223, DateTimeKind.Utc).AddTicks(5040) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 6, 3, 57, 499, DateTimeKind.Utc).AddTicks(7030), new DateTime(2024, 6, 24, 6, 3, 57, 499, DateTimeKind.Utc).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 6, 3, 57, 499, DateTimeKind.Utc).AddTicks(7030), new DateTime(2024, 6, 24, 6, 3, 57, 499, DateTimeKind.Utc).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 6, 3, 57, 499, DateTimeKind.Utc).AddTicks(7030), new DateTime(2024, 6, 24, 6, 3, 57, 499, DateTimeKind.Utc).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 6, 3, 57, 499, DateTimeKind.Utc).AddTicks(7030), new DateTime(2024, 6, 24, 6, 3, 57, 499, DateTimeKind.Utc).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "Name", "Password", "RoleId", "Surname", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 6, 3, 57, 498, DateTimeKind.Utc).AddTicks(610), "Elgun02@gmail.com", "Elgun", "Elgun123", 1, "Haqverdiyev", new DateTime(2024, 6, 24, 6, 3, 57, 498, DateTimeKind.Utc).AddTicks(610) });
        }
    }
}
