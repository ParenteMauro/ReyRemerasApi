using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReyRemerasApi.Migrations
{
    /// <inheritdoc />
    public partial class StockProductsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Product = table.Column<int>(type: "int", nullable: false),
                    Id_Color = table.Column<int>(type: "int", nullable: false),
                    Id_Size = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockProducts_Color_Id_Color",
                        column: x => x.Id_Color,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockProducts_Product_Id_Product",
                        column: x => x.Id_Product,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockProducts_Size_Id_Size",
                        column: x => x.Id_Size,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockProducts_Id_Color",
                table: "StockProducts",
                column: "Id_Color");

            migrationBuilder.CreateIndex(
                name: "IX_StockProducts_Id_Product",
                table: "StockProducts",
                column: "Id_Product");

            migrationBuilder.CreateIndex(
                name: "IX_StockProducts_Id_Size",
                table: "StockProducts",
                column: "Id_Size");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockProducts");
        }
    }
}
