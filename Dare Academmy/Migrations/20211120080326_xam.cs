using Microsoft.EntityFrameworkCore.Migrations;

namespace Dare_Academmy.Migrations
{
    public partial class xam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "country_idId",
                table: "city",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_city_country_idId",
                table: "city",
                column: "country_idId");

            migrationBuilder.AddForeignKey(
                name: "FK_city_country_country_idId",
                table: "city",
                column: "country_idId",
                principalTable: "country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_city_country_country_idId",
                table: "city");

            migrationBuilder.DropIndex(
                name: "IX_city_country_idId",
                table: "city");

            migrationBuilder.DropColumn(
                name: "country_idId",
                table: "city");
        }
    }
}
