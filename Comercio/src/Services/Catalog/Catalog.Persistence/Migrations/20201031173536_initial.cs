using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Migrations
{
    public partial class initial : Migration
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
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
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
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductID", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product {i}", "Product 1", 518m },
                    { 73, "Description for product {i}", "Product 73", 962m },
                    { 72, "Description for product {i}", "Product 72", 928m },
                    { 71, "Description for product {i}", "Product 71", 938m },
                    { 70, "Description for product {i}", "Product 70", 119m },
                    { 69, "Description for product {i}", "Product 69", 805m },
                    { 68, "Description for product {i}", "Product 68", 103m },
                    { 67, "Description for product {i}", "Product 67", 867m },
                    { 66, "Description for product {i}", "Product 66", 821m },
                    { 65, "Description for product {i}", "Product 65", 862m },
                    { 64, "Description for product {i}", "Product 64", 981m },
                    { 63, "Description for product {i}", "Product 63", 270m },
                    { 62, "Description for product {i}", "Product 62", 753m },
                    { 61, "Description for product {i}", "Product 61", 962m },
                    { 60, "Description for product {i}", "Product 60", 857m },
                    { 59, "Description for product {i}", "Product 59", 357m },
                    { 58, "Description for product {i}", "Product 58", 203m },
                    { 57, "Description for product {i}", "Product 57", 846m },
                    { 56, "Description for product {i}", "Product 56", 519m },
                    { 55, "Description for product {i}", "Product 55", 603m },
                    { 54, "Description for product {i}", "Product 54", 972m },
                    { 53, "Description for product {i}", "Product 53", 265m },
                    { 74, "Description for product {i}", "Product 74", 139m },
                    { 52, "Description for product {i}", "Product 52", 389m },
                    { 75, "Description for product {i}", "Product 75", 589m },
                    { 77, "Description for product {i}", "Product 77", 990m },
                    { 98, "Description for product {i}", "Product 98", 127m },
                    { 97, "Description for product {i}", "Product 97", 978m },
                    { 96, "Description for product {i}", "Product 96", 929m },
                    { 95, "Description for product {i}", "Product 95", 139m },
                    { 94, "Description for product {i}", "Product 94", 887m },
                    { 93, "Description for product {i}", "Product 93", 752m },
                    { 92, "Description for product {i}", "Product 92", 492m },
                    { 91, "Description for product {i}", "Product 91", 670m },
                    { 90, "Description for product {i}", "Product 90", 790m },
                    { 89, "Description for product {i}", "Product 89", 984m },
                    { 88, "Description for product {i}", "Product 88", 523m },
                    { 87, "Description for product {i}", "Product 87", 130m },
                    { 86, "Description for product {i}", "Product 86", 426m },
                    { 85, "Description for product {i}", "Product 85", 573m },
                    { 84, "Description for product {i}", "Product 84", 735m },
                    { 83, "Description for product {i}", "Product 83", 496m },
                    { 82, "Description for product {i}", "Product 82", 223m },
                    { 81, "Description for product {i}", "Product 81", 485m },
                    { 80, "Description for product {i}", "Product 80", 620m },
                    { 79, "Description for product {i}", "Product 79", 351m },
                    { 78, "Description for product {i}", "Product 78", 618m },
                    { 76, "Description for product {i}", "Product 76", 477m },
                    { 51, "Description for product {i}", "Product 51", 705m },
                    { 50, "Description for product {i}", "Product 50", 590m },
                    { 49, "Description for product {i}", "Product 49", 213m },
                    { 22, "Description for product {i}", "Product 22", 999m },
                    { 21, "Description for product {i}", "Product 21", 626m },
                    { 20, "Description for product {i}", "Product 20", 273m },
                    { 19, "Description for product {i}", "Product 19", 141m },
                    { 18, "Description for product {i}", "Product 18", 707m },
                    { 17, "Description for product {i}", "Product 17", 939m },
                    { 16, "Description for product {i}", "Product 16", 534m },
                    { 15, "Description for product {i}", "Product 15", 536m },
                    { 14, "Description for product {i}", "Product 14", 115m },
                    { 13, "Description for product {i}", "Product 13", 591m },
                    { 12, "Description for product {i}", "Product 12", 363m },
                    { 11, "Description for product {i}", "Product 11", 117m },
                    { 10, "Description for product {i}", "Product 10", 578m },
                    { 9, "Description for product {i}", "Product 9", 260m },
                    { 8, "Description for product {i}", "Product 8", 496m },
                    { 7, "Description for product {i}", "Product 7", 363m },
                    { 6, "Description for product {i}", "Product 6", 484m },
                    { 5, "Description for product {i}", "Product 5", 227m },
                    { 4, "Description for product {i}", "Product 4", 826m },
                    { 3, "Description for product {i}", "Product 3", 125m },
                    { 2, "Description for product {i}", "Product 2", 517m },
                    { 23, "Description for product {i}", "Product 23", 671m },
                    { 24, "Description for product {i}", "Product 24", 921m },
                    { 25, "Description for product {i}", "Product 25", 568m },
                    { 26, "Description for product {i}", "Product 26", 369m },
                    { 48, "Description for product {i}", "Product 48", 397m },
                    { 47, "Description for product {i}", "Product 47", 883m },
                    { 46, "Description for product {i}", "Product 46", 947m },
                    { 45, "Description for product {i}", "Product 45", 670m },
                    { 44, "Description for product {i}", "Product 44", 153m },
                    { 43, "Description for product {i}", "Product 43", 109m },
                    { 42, "Description for product {i}", "Product 42", 249m },
                    { 41, "Description for product {i}", "Product 41", 683m },
                    { 40, "Description for product {i}", "Product 40", 101m },
                    { 39, "Description for product {i}", "Product 39", 745m },
                    { 99, "Description for product {i}", "Product 99", 290m },
                    { 38, "Description for product {i}", "Product 38", 110m },
                    { 36, "Description for product {i}", "Product 36", 516m },
                    { 35, "Description for product {i}", "Product 35", 310m },
                    { 34, "Description for product {i}", "Product 34", 588m },
                    { 33, "Description for product {i}", "Product 33", 496m },
                    { 32, "Description for product {i}", "Product 32", 295m },
                    { 31, "Description for product {i}", "Product 31", 716m },
                    { 30, "Description for product {i}", "Product 30", 278m },
                    { 29, "Description for product {i}", "Product 29", 325m },
                    { 28, "Description for product {i}", "Product 28", 609m },
                    { 27, "Description for product {i}", "Product 27", 521m },
                    { 37, "Description for product {i}", "Product 37", 595m },
                    { 100, "Description for product {i}", "Product 100", 849m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 464 },
                    { 73, 73, 143 },
                    { 72, 72, 480 },
                    { 71, 71, 788 },
                    { 70, 70, 789 },
                    { 69, 69, 981 },
                    { 68, 68, 225 },
                    { 67, 67, 830 },
                    { 66, 66, 287 },
                    { 65, 65, 107 },
                    { 64, 64, 292 },
                    { 63, 63, 230 },
                    { 62, 62, 809 },
                    { 61, 61, 983 },
                    { 60, 60, 630 },
                    { 59, 59, 234 },
                    { 58, 58, 424 },
                    { 57, 57, 260 },
                    { 56, 56, 604 },
                    { 55, 55, 317 },
                    { 54, 54, 702 },
                    { 53, 53, 236 },
                    { 74, 74, 885 },
                    { 52, 52, 173 },
                    { 75, 75, 967 },
                    { 77, 77, 184 },
                    { 98, 98, 583 },
                    { 97, 97, 596 },
                    { 96, 96, 576 },
                    { 95, 95, 912 },
                    { 94, 94, 736 },
                    { 93, 93, 292 },
                    { 92, 92, 950 },
                    { 91, 91, 927 },
                    { 90, 90, 118 },
                    { 89, 89, 396 },
                    { 88, 88, 290 },
                    { 87, 87, 190 },
                    { 86, 86, 993 },
                    { 85, 85, 794 },
                    { 84, 84, 570 },
                    { 83, 83, 838 },
                    { 82, 82, 502 },
                    { 81, 81, 405 },
                    { 80, 80, 574 },
                    { 79, 79, 931 },
                    { 78, 78, 421 },
                    { 76, 76, 310 },
                    { 51, 51, 297 },
                    { 50, 50, 763 },
                    { 49, 49, 303 },
                    { 22, 22, 860 },
                    { 21, 21, 937 },
                    { 20, 20, 353 },
                    { 19, 19, 782 },
                    { 18, 18, 410 },
                    { 17, 17, 807 },
                    { 16, 16, 164 },
                    { 15, 15, 877 },
                    { 14, 14, 604 },
                    { 13, 13, 739 },
                    { 12, 12, 723 },
                    { 11, 11, 514 },
                    { 10, 10, 174 },
                    { 9, 9, 284 },
                    { 8, 8, 464 },
                    { 7, 7, 851 },
                    { 6, 6, 852 },
                    { 5, 5, 101 },
                    { 4, 4, 934 },
                    { 3, 3, 983 },
                    { 2, 2, 375 },
                    { 23, 23, 214 },
                    { 24, 24, 658 },
                    { 25, 25, 800 },
                    { 26, 26, 471 },
                    { 48, 48, 466 },
                    { 47, 47, 165 },
                    { 46, 46, 325 },
                    { 45, 45, 727 },
                    { 44, 44, 793 },
                    { 43, 43, 775 },
                    { 42, 42, 727 },
                    { 41, 41, 386 },
                    { 40, 40, 896 },
                    { 39, 39, 366 },
                    { 99, 99, 785 },
                    { 38, 38, 427 },
                    { 36, 36, 187 },
                    { 35, 35, 623 },
                    { 34, 34, 613 },
                    { 33, 33, 893 },
                    { 32, 32, 326 },
                    { 31, 31, 166 },
                    { 30, 30, 992 },
                    { 29, 29, 333 },
                    { 28, 28, 141 },
                    { 27, 27, 868 },
                    { 37, 37, 375 },
                    { 100, 100, 539 }
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
