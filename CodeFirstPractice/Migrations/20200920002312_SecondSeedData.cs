using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstPractice.Migrations
{
    public partial class SecondSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ShelfMaterial",
                columns: new[] { "id", "material_name" },
                values: new object[,]
                {
                    { 1, "Birch" },
                    { 2, "Pine" },
                    { 3, "Aspen" },
                    { 4, "Cherry" },
                    { 5, "Mahogany" },
                    { 6, "Endangered Species" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShelfMaterial",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShelfMaterial",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShelfMaterial",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShelfMaterial",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ShelfMaterial",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ShelfMaterial",
                keyColumn: "id",
                keyValue: 6);
        }
    }
}
