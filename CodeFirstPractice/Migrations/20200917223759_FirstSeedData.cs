using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstPractice.Migrations
{
    public partial class FirstSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shelves",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 3, "toilet shelf" },
                    { 4, "school shelf" },
                    { 5, "computer shelf" },
                    { 6, "figurine shelf" },
                    { 7, "game shelf" }
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
        }
    }
}
