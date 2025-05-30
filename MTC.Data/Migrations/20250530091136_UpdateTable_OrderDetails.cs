using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MTC.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable_OrderDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PizzaId",
                table: "OrderDetails",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PizzaId",
                table: "OrderDetails",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Pizzas_PizzaId",
                table: "OrderDetails",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Pizzas_PizzaId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_PizzaId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "PizzaId",
                table: "OrderDetails");
        }
    }
}
