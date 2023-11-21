using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WSAD_Final_Project.Migrations.Cars
{
    /// <inheritdoc />
    public partial class Cars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarMake = table.Column<int>(type: "int", nullable: false),
                    CarModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarYear = table.Column<int>(type: "int", nullable: false),
                    BoughtYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "BoughtYear", "CarMake", "CarModel", "CarYear" },
                values: new object[,]
                {
                    { 1, 2016, 17, "Civic", 2005 },
                    { 2, 2017, 17, "Civic", 2006 },
                    { 3, 2018, 8, "CTS", 2008 },
                    { 4, 2018, 46, "MR2", 1988 },
                    { 5, 2019, 17, "Del Sol", 1994 },
                    { 6, 2021, 14, "F150", 1999 },
                    { 7, 2022, 14, "F250", 2001 },
                    { 8, 2023, 31, "B2000", 1999 },
                    { 9, 2022, 22, "Ninja", 2008 },
                    { 10, 2022, 44, "GS750T", 1982 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
