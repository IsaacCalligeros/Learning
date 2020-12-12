using Microsoft.EntityFrameworkCore.Migrations;

namespace ReactHomePage.Migrations
{
    public partial class ContainersUpdate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ControlId",
                table: "Containers");

            migrationBuilder.AddColumn<int>(
                name: "ContainerId",
                table: "Layout",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContainerId",
                table: "Layout");

            migrationBuilder.AddColumn<int>(
                name: "ControlId",
                table: "Containers",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
