using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDatabase.Migrations
{
    /// <inheritdoc />
    public partial class CategorisAndKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    categorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriesName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.categorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_product_CategoryId",
                table: "product",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_product_categories_CategoryId",
                table: "product",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "categorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_categories_CategoryId",
                table: "product");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropIndex(
                name: "IX_product_CategoryId",
                table: "product");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "product");
        }
    }
}
