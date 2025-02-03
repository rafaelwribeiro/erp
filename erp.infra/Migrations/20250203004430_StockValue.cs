using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace erp.infra.Migrations
{
    /// <inheritdoc />
    public partial class StockValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "StockMovements",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitValue",
                table: "StockMovements",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "StockMovements");

            migrationBuilder.DropColumn(
                name: "UnitValue",
                table: "StockMovements");
        }
    }
}
