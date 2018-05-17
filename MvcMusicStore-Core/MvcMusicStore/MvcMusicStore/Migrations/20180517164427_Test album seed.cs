using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMusicStore.Migrations
{
    public partial class Testalbumseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumArtUrl", "ArtistId", "GenreId", "Price", "Title" },
                values: new object[] { 1, "/Content/Images/placeholder.gif", 90, 1, 8.99m, "The Best Of Men At Work" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1);
        }
    }
}
