using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDatabase.Migrations
{
    /// <inheritdoc />
    public partial class ProducktRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productRatings",
                columns: table => new
                {
                    ProductRatingsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productRatings", x => x.ProductRatingsId);
                    table.ForeignKey(
                        name: "FK_productRatings_product_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "product",
                        principalColumn: "ProductsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_productRatings_ProductsId",
                table: "productRatings",
                column: "ProductsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productRatings");
        }
    }
}
