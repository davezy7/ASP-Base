using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestPostGis.Migrations
{
    public partial class InitPostGi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Geometries",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Geometries");
        }
    }
}
