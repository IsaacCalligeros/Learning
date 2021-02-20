using Microsoft.EntityFrameworkCore.Migrations;

namespace ReactHomePage.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Layouts_Containers_ContainerId",
                table: "Layouts");

            migrationBuilder.DropIndex(
                name: "IX_Layouts_ContainerId",
                table: "Layouts");

            migrationBuilder.DropColumn(
                name: "ContainerId",
                table: "Layouts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContainerId",
                table: "Layouts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Layouts_ContainerId",
                table: "Layouts",
                column: "ContainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Layouts_Containers_ContainerId",
                table: "Layouts",
                column: "ContainerId",
                principalTable: "Containers",
                principalColumn: "ContainerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
