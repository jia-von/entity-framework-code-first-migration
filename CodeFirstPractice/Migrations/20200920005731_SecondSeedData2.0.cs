using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstPractice.Migrations
{
    public partial class SecondSeedData20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "id", "name", "shelf_materials_id" },
                values: new object[,]
                {
                    { 3, "Mista Shelf", 1 },
                    { 4, "Golden Shelf", 2 },
                    { 5, "Painful Shelf", 3 },
                    { 6, "Mr. Shelf", 4 },
                    { 7, "Mr. Shelf", 5 },
                    { 11, "Mr. Shelf", 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shelves",
                keyColumn: "id",
                keyValue: 11);
        }
    }
}
