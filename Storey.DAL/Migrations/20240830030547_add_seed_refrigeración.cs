using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Storey.DAL.Migrations
{
    /// <inheritdoc />
    public partial class add_seed_refrigeración : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "CategoriaItemId", "CategoriaId", "Elemento", "Valor" },
                values: new object[,]
                {
                    { 6, 2, "Heladera", 1000 },
                    { 7, 2, "Freezer", 1500 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "CategoriaItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "CategoriaItemId",
                keyValue: 7);
        }
    }
}
