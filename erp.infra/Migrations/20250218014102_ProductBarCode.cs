using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace erp.infra.Migrations
{
    /// <inheritdoc />
    public partial class ProductBarCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BarCode",
                table: "Products",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BarCode",
                table: "Products",
                column: "BarCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_BarCode",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BarCode",
                table: "Products");
        }
    }
}
