using Microsoft.EntityFrameworkCore.Migrations;

namespace Ejemplo.Webapi.Migrations
{
    public partial class Migracion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Manager",
                table: "foolbalteams",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manager",
                table: "foolbalteams");
        }
    }
}
