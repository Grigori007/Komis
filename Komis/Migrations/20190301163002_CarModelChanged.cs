using Microsoft.EntityFrameworkCore.Migrations;

namespace Komis.Migrations
{
    public partial class CarModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInHQ",
                table: "Cars",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInHQ",
                table: "Cars");
        }
    }
}
