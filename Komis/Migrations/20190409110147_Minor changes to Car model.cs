using Microsoft.EntityFrameworkCore.Migrations;

namespace Komis.Migrations
{
    public partial class MinorchangestoCarmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MiniImageUrl",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MiniImageUrl",
                table: "Cars",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Cars",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
