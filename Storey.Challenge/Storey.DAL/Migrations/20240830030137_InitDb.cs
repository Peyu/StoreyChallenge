using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Storey.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    CategoriaItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Elemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.CategoriaItemId);
                    table.ForeignKey(
                        name: "FK_Item_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Iluminación" },
                    { 2, "Refrigeración" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "CategoriaItemId", "CategoriaId", "Elemento", "Valor" },
                values: new object[,]
                {
                    { 1, 1, "Lámpara Led de 5w", 5 },
                    { 2, 1, "Lámpara Led de 10w", 10 },
                    { 3, 1, "Lámpara Incandescente de 40w", 40 },
                    { 4, 1, "Lámpara Incandescente de 100w", 100 },
                    { 5, 1, "Lámpara Incandescente de 400w", 400 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_CategoriaId",
                table: "Item",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
