using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WSAD_Final_Project.Migrations.Games
{
    /// <inheritdoc />
    public partial class Games : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Developer", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, "Sega", 2022, "Sonic Frontiers" },
                    { 2, "Sora Ltd.", 2017, "Super Smash Bros. Ultimate" },
                    { 3, "Sora Ltd.", 2014, "Super Smash Bros. Wii U" },
                    { 4, "Nintendo", 2017, "Mario Kart 8 Deluxe" },
                    { 5, "Nintendo", 2010, "Sonic Colors" },
                    { 6, "Microsoft", 2012, "Halo 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
