using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MTC.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateCategoryConfigurationAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "101f4fb4-2c6f-4734-9fa1-c1d4bf185deb", "Classic" },
                    { "442c8d99-3b07-4aaf-9b07-a562ca32f0eb", "Chicken" },
                    { "55596daa-2de7-47d0-9372-4860ff3c17a2", "Veggie" },
                    { "ce275698-9c28-422e-8c07-8b913e8bb283", "Supreme" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "101f4fb4-2c6f-4734-9fa1-c1d4bf185deb");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "442c8d99-3b07-4aaf-9b07-a562ca32f0eb");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "55596daa-2de7-47d0-9372-4860ff3c17a2");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: "ce275698-9c28-422e-8c07-8b913e8bb283");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);
        }
    }
}
