using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Artisanaux.Services.ProductAPI.Migrations
{
    public partial class boutainaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "ImageURL", "Price", "ProductName" },
                values: new object[,]
                {
                    { 2, "categorie 1", "https://artisana.blob.core.windows.net/artisana/1.jpg", 123.0, "Tapis" },
                    { 3, "categorie 2", "https://artisana.blob.core.windows.net/artisana/2.jpg", 15.0, "Sacs" },
                    { 4, "categorie 3", "https://artisana.blob.core.windows.net/artisana/3.jpeg", 123.0, "Couvre" },
                    { 5, "categorie 4", "https://artisana.blob.core.windows.net/artisana/4.jpg", 123.0, "Vers" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);
        }
    }
}
