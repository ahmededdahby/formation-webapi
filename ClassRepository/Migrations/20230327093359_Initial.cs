using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassRepository.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuisines",
                columns: table => new
                {
                    CuisineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuisines", x => x.CuisineId);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuisineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurants_Cuisines_CuisineId",
                        column: x => x.CuisineId,
                        principalTable: "Cuisines",
                        principalColumn: "CuisineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cuisines",
                columns: new[] { "CuisineId", "Name" },
                values: new object[,]
                {
                    { 1, "Italian" },
                    { 2, "French" },
                    { 3, "Japanese" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "CuisineId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, "We sell delicious fool", "Liverfool" },
                    { 2, 1, "Authentic Italian pizzas made fresh daily", "Pizza Palace" },
                    { 3, 1, "Juicy burgers and crispy fries", "Burger Barn" },
                    { 4, 1, "Fresh sushi rolls and sashimi", "Sushi Spot" },
                    { 5, 1, "Authentic Mexican tacos and burritos", "Taco Town" },
                    { 6, 1, "Spicy and flavorful Indian curries", "Curry House" },
                    { 7, 1, "Authentic Thai cuisine with a view", "Thai Terrace" },
                    { 8, 1, "Juicy steaks cooked to perfection", "Steakhouse" },
                    { 9, 1, "Satisfying bowls of ramen noodles", "Ramen Rave" },
                    { 10, 1, "Fresh seafood and shellfish dishes", "Seafood Shack" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_CuisineId",
                table: "Restaurants",
                column: "CuisineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Cuisines");
        }
    }
}
