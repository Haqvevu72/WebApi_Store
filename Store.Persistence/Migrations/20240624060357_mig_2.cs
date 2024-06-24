using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Store.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "InvoiceItems");

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 6, 3, 57, 498, DateTimeKind.Utc).AddTicks(610), new DateTime(2024, 6, 24, 6, 3, 57, 498, DateTimeKind.Utc).AddTicks(610) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "InvoiceItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 5, 15, 43, 859, DateTimeKind.Utc).AddTicks(6500), new DateTime(2024, 6, 24, 5, 15, 43, 859, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 5, 15, 43, 859, DateTimeKind.Utc).AddTicks(6500), new DateTime(2024, 6, 24, 5, 15, 43, 859, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 5, 15, 43, 859, DateTimeKind.Utc).AddTicks(6510), new DateTime(2024, 6, 24, 5, 15, 43, 859, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 5, 15, 43, 859, DateTimeKind.Utc).AddTicks(6510), new DateTime(2024, 6, 24, 5, 15, 43, 859, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 5, 15, 43, 857, DateTimeKind.Utc).AddTicks(9690), new DateTime(2024, 6, 24, 5, 15, 43, 857, DateTimeKind.Utc).AddTicks(9690) });
        }
    }
}
