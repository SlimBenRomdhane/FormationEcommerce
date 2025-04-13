using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormationEcommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreationDate", "Description", "LastModificationDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0a7c2761-f7f9-492c-9ff6-804eb86ba293"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Literature and novels", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Books" },
                    { new Guid("1803c422-d49a-4e0b-92d4-220380754af3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apparel and accessories", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clothing" },
                    { new Guid("3fd18d4b-f9f1-47e1-ba75-ed9c9c9f0360"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Devices and gadgets", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electronics" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a7c2761-f7f9-492c-9ff6-804eb86ba293"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1803c422-d49a-4e0b-92d4-220380754af3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3fd18d4b-f9f1-47e1-ba75-ed9c9c9f0360"));
        }
    }
}
