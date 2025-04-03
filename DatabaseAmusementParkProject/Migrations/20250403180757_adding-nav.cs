using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAmusementParkProject.Migrations
{
    /// <inheritdoc />
    public partial class addingnav : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User_Favorites");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Locations",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Locations",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ThemeParks_Review_ThemeParkLocationId",
                table: "ThemeParks_Review",
                column: "ThemeParkLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ThemeParks_Review_UserId",
                table: "ThemeParks_Review",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ThemeParks_Locations_LocationId",
                table: "ThemeParks_Locations",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ThemeParks_Locations_ThemeParkId",
                table: "ThemeParks_Locations",
                column: "ThemeParkId");

            migrationBuilder.AddForeignKey(
                name: "FK_ThemeParks_Locations_Locations_LocationId",
                table: "ThemeParks_Locations",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThemeParks_Locations_ThemeParks_ThemeParkId",
                table: "ThemeParks_Locations",
                column: "ThemeParkId",
                principalTable: "ThemeParks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThemeParks_Review_ThemeParks_Locations_ThemeParkLocationId",
                table: "ThemeParks_Review",
                column: "ThemeParkLocationId",
                principalTable: "ThemeParks_Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThemeParks_Review_Users_UserId",
                table: "ThemeParks_Review",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThemeParks_Locations_Locations_LocationId",
                table: "ThemeParks_Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_ThemeParks_Locations_ThemeParks_ThemeParkId",
                table: "ThemeParks_Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_ThemeParks_Review_ThemeParks_Locations_ThemeParkLocationId",
                table: "ThemeParks_Review");

            migrationBuilder.DropForeignKey(
                name: "FK_ThemeParks_Review_Users_UserId",
                table: "ThemeParks_Review");

            migrationBuilder.DropIndex(
                name: "IX_ThemeParks_Review_ThemeParkLocationId",
                table: "ThemeParks_Review");

            migrationBuilder.DropIndex(
                name: "IX_ThemeParks_Review_UserId",
                table: "ThemeParks_Review");

            migrationBuilder.DropIndex(
                name: "IX_ThemeParks_Locations_LocationId",
                table: "ThemeParks_Locations");

            migrationBuilder.DropIndex(
                name: "IX_ThemeParks_Locations_ThemeParkId",
                table: "ThemeParks_Locations");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Locations",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Locations",
                newName: "id");

            migrationBuilder.CreateTable(
                name: "User_Favorites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ThemeParkId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Favorites", x => x.Id);
                });
        }
    }
}
