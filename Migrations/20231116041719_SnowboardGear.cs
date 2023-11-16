using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WSAD_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class SnowboardGear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SnowboardGear",
                columns: table => new
                {
                    GearId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GearType = table.Column<int>(type: "int", nullable: true),
                    Brand = table.Column<int>(type: "int", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnowboardGear", x => x.GearId);
                });

            migrationBuilder.InsertData(
                table: "SnowboardGear",
                columns: new[] { "GearId", "Brand", "GearType", "Model" },
                values: new object[,]
                {
                    { 1, 0, 0, "Custom" },
                    { 2, 8, 1, "Force" },
                    { 3, 9, 2, "Hi-Standard" },
                    { 4, 10, 3, "Snow Shell" },
                    { 5, 11, 5, "I/O Mag" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SnowboardGear");
        }
    }
}
