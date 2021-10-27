using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class initialize1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 484m },
                    { 73, "Description for product 73", "Product 73", 496m },
                    { 72, "Description for product 72", "Product 72", 490m },
                    { 71, "Description for product 71", "Product 71", 810m },
                    { 70, "Description for product 70", "Product 70", 968m },
                    { 69, "Description for product 69", "Product 69", 776m },
                    { 68, "Description for product 68", "Product 68", 461m },
                    { 67, "Description for product 67", "Product 67", 850m },
                    { 66, "Description for product 66", "Product 66", 545m },
                    { 65, "Description for product 65", "Product 65", 428m },
                    { 64, "Description for product 64", "Product 64", 540m },
                    { 63, "Description for product 63", "Product 63", 121m },
                    { 62, "Description for product 62", "Product 62", 601m },
                    { 61, "Description for product 61", "Product 61", 414m },
                    { 60, "Description for product 60", "Product 60", 618m },
                    { 59, "Description for product 59", "Product 59", 482m },
                    { 58, "Description for product 58", "Product 58", 922m },
                    { 57, "Description for product 57", "Product 57", 564m },
                    { 56, "Description for product 56", "Product 56", 438m },
                    { 55, "Description for product 55", "Product 55", 888m },
                    { 54, "Description for product 54", "Product 54", 668m },
                    { 53, "Description for product 53", "Product 53", 819m },
                    { 74, "Description for product 74", "Product 74", 580m },
                    { 52, "Description for product 52", "Product 52", 160m },
                    { 75, "Description for product 75", "Product 75", 531m },
                    { 77, "Description for product 77", "Product 77", 976m },
                    { 98, "Description for product 98", "Product 98", 630m },
                    { 97, "Description for product 97", "Product 97", 620m },
                    { 96, "Description for product 96", "Product 96", 167m },
                    { 95, "Description for product 95", "Product 95", 862m },
                    { 94, "Description for product 94", "Product 94", 905m },
                    { 93, "Description for product 93", "Product 93", 712m },
                    { 92, "Description for product 92", "Product 92", 609m },
                    { 91, "Description for product 91", "Product 91", 978m },
                    { 90, "Description for product 90", "Product 90", 156m },
                    { 89, "Description for product 89", "Product 89", 415m },
                    { 88, "Description for product 88", "Product 88", 228m },
                    { 87, "Description for product 87", "Product 87", 561m },
                    { 86, "Description for product 86", "Product 86", 929m },
                    { 85, "Description for product 85", "Product 85", 841m },
                    { 84, "Description for product 84", "Product 84", 374m },
                    { 83, "Description for product 83", "Product 83", 627m },
                    { 82, "Description for product 82", "Product 82", 546m },
                    { 81, "Description for product 81", "Product 81", 769m },
                    { 80, "Description for product 80", "Product 80", 910m },
                    { 79, "Description for product 79", "Product 79", 984m },
                    { 78, "Description for product 78", "Product 78", 860m },
                    { 76, "Description for product 76", "Product 76", 373m },
                    { 51, "Description for product 51", "Product 51", 873m },
                    { 50, "Description for product 50", "Product 50", 185m },
                    { 49, "Description for product 49", "Product 49", 953m },
                    { 22, "Description for product 22", "Product 22", 146m },
                    { 21, "Description for product 21", "Product 21", 916m },
                    { 20, "Description for product 20", "Product 20", 200m },
                    { 19, "Description for product 19", "Product 19", 757m },
                    { 18, "Description for product 18", "Product 18", 921m },
                    { 17, "Description for product 17", "Product 17", 586m },
                    { 16, "Description for product 16", "Product 16", 341m },
                    { 15, "Description for product 15", "Product 15", 512m },
                    { 14, "Description for product 14", "Product 14", 271m },
                    { 13, "Description for product 13", "Product 13", 666m },
                    { 12, "Description for product 12", "Product 12", 647m },
                    { 11, "Description for product 11", "Product 11", 826m },
                    { 10, "Description for product 10", "Product 10", 417m },
                    { 9, "Description for product 9", "Product 9", 255m },
                    { 8, "Description for product 8", "Product 8", 481m },
                    { 7, "Description for product 7", "Product 7", 182m },
                    { 6, "Description for product 6", "Product 6", 686m },
                    { 5, "Description for product 5", "Product 5", 766m },
                    { 4, "Description for product 4", "Product 4", 933m },
                    { 3, "Description for product 3", "Product 3", 674m },
                    { 2, "Description for product 2", "Product 2", 155m },
                    { 23, "Description for product 23", "Product 23", 590m },
                    { 24, "Description for product 24", "Product 24", 752m },
                    { 25, "Description for product 25", "Product 25", 551m },
                    { 26, "Description for product 26", "Product 26", 247m },
                    { 48, "Description for product 48", "Product 48", 825m },
                    { 47, "Description for product 47", "Product 47", 478m },
                    { 46, "Description for product 46", "Product 46", 640m },
                    { 45, "Description for product 45", "Product 45", 768m },
                    { 44, "Description for product 44", "Product 44", 730m },
                    { 43, "Description for product 43", "Product 43", 170m },
                    { 42, "Description for product 42", "Product 42", 642m },
                    { 41, "Description for product 41", "Product 41", 669m },
                    { 40, "Description for product 40", "Product 40", 277m },
                    { 39, "Description for product 39", "Product 39", 524m },
                    { 99, "Description for product 99", "Product 99", 402m },
                    { 38, "Description for product 38", "Product 38", 195m },
                    { 36, "Description for product 36", "Product 36", 543m },
                    { 35, "Description for product 35", "Product 35", 494m },
                    { 34, "Description for product 34", "Product 34", 304m },
                    { 33, "Description for product 33", "Product 33", 797m },
                    { 32, "Description for product 32", "Product 32", 381m },
                    { 31, "Description for product 31", "Product 31", 989m },
                    { 30, "Description for product 30", "Product 30", 715m },
                    { 29, "Description for product 29", "Product 29", 459m },
                    { 28, "Description for product 28", "Product 28", 581m },
                    { 27, "Description for product 27", "Product 27", 371m },
                    { 37, "Description for product 37", "Product 37", 531m },
                    { 100, "Description for product 100", "Product 100", 323m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 9 },
                    { 73, 73, 1 },
                    { 72, 72, 19 },
                    { 71, 71, 11 },
                    { 70, 70, 19 },
                    { 69, 69, 12 },
                    { 68, 68, 3 },
                    { 67, 67, 2 },
                    { 66, 66, 15 },
                    { 65, 65, 0 },
                    { 64, 64, 17 },
                    { 63, 63, 11 },
                    { 62, 62, 0 },
                    { 61, 61, 2 },
                    { 60, 60, 18 },
                    { 59, 59, 0 },
                    { 58, 58, 6 },
                    { 57, 57, 16 },
                    { 56, 56, 6 },
                    { 55, 55, 11 },
                    { 54, 54, 3 },
                    { 53, 53, 10 },
                    { 74, 74, 6 },
                    { 52, 52, 9 },
                    { 75, 75, 19 },
                    { 77, 77, 18 },
                    { 98, 98, 7 },
                    { 97, 97, 2 },
                    { 96, 96, 16 },
                    { 95, 95, 10 },
                    { 94, 94, 0 },
                    { 93, 93, 15 },
                    { 92, 92, 10 },
                    { 91, 91, 6 },
                    { 90, 90, 17 },
                    { 89, 89, 9 },
                    { 88, 88, 4 },
                    { 87, 87, 9 },
                    { 86, 86, 8 },
                    { 85, 85, 2 },
                    { 84, 84, 17 },
                    { 83, 83, 10 },
                    { 82, 82, 14 },
                    { 81, 81, 1 },
                    { 80, 80, 1 },
                    { 79, 79, 10 },
                    { 78, 78, 10 },
                    { 76, 76, 8 },
                    { 51, 51, 8 },
                    { 50, 50, 19 },
                    { 49, 49, 8 },
                    { 22, 22, 2 },
                    { 21, 21, 1 },
                    { 20, 20, 17 },
                    { 19, 19, 0 },
                    { 18, 18, 0 },
                    { 17, 17, 16 },
                    { 16, 16, 8 },
                    { 15, 15, 2 },
                    { 14, 14, 17 },
                    { 13, 13, 4 },
                    { 12, 12, 11 },
                    { 11, 11, 15 },
                    { 10, 10, 18 },
                    { 9, 9, 8 },
                    { 8, 8, 8 },
                    { 7, 7, 19 },
                    { 6, 6, 18 },
                    { 5, 5, 10 },
                    { 4, 4, 11 },
                    { 3, 3, 1 },
                    { 2, 2, 18 },
                    { 23, 23, 1 },
                    { 24, 24, 15 },
                    { 25, 25, 10 },
                    { 26, 26, 12 },
                    { 48, 48, 0 },
                    { 47, 47, 10 },
                    { 46, 46, 9 },
                    { 45, 45, 5 },
                    { 44, 44, 11 },
                    { 43, 43, 4 },
                    { 42, 42, 13 },
                    { 41, 41, 17 },
                    { 40, 40, 13 },
                    { 39, 39, 18 },
                    { 99, 99, 10 },
                    { 38, 38, 16 },
                    { 36, 36, 2 },
                    { 35, 35, 4 },
                    { 34, 34, 1 },
                    { 33, 33, 8 },
                    { 32, 32, 0 },
                    { 31, 31, 18 },
                    { 30, 30, 11 },
                    { 29, 29, 17 },
                    { 28, 28, 18 },
                    { 27, 27, 15 },
                    { 37, 37, 16 },
                    { 100, 100, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
