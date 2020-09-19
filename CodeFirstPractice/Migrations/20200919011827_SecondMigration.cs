using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstPractice.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "shelf_materials_id",
                table: "Shelves",
                type: "int(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ShelfMaterial",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(10)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    material_name = table.Column<string>(type: "varchar(25)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                        .Annotation("MySql:Collation", "utf8mb4_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShelfMaterial", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "FK_Shelves_ShelfMaterials",
                table: "Shelves",
                column: "shelf_materials_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shelves_ShelfMaterials",
                table: "Shelves",
                column: "shelf_materials_id",
                principalTable: "ShelfMaterial",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shelves_ShelfMaterials",
                table: "Shelves");

            migrationBuilder.DropTable(
                name: "ShelfMaterial");

            migrationBuilder.DropIndex(
                name: "FK_Shelves_ShelfMaterials",
                table: "Shelves");

            migrationBuilder.DropColumn(
                name: "shelf_materials_id",
                table: "Shelves");

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
    }
}
