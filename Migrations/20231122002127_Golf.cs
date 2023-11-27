using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WSAD_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class Golf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "golfGears",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_golfGears", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "golfGears",
                columns: new[] { "Id", "Brand", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Callaway", "Paradym", "Driver" },
                    { 2, "Taylormade", "Stealth 2", "Driver" },
                    { 3, "Titleist", "Vokey", "Wedge" },
                    { 4, "Ping", "G425", "Irons" },
                    { 5, "Taylormade", "Spider", "Putter" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "golfGears");
        }
    }
}
