using Microsoft.EntityFrameworkCore.Migrations;

namespace ReactHomePage.Migrations
{
    public partial class UpdatingEquities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equities_Portfolios_PortfolioId",
                table: "Equities");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_User_UserId",
                table: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_UserId",
                table: "Portfolios");

            migrationBuilder.AlterColumn<int>(
                name: "PortfolioId",
                table: "Equities",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "NumberHeld",
                table: "Equities",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PurchasePrice",
                table: "Equities",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddForeignKey(
                name: "FK_Equities_Portfolios_PortfolioId",
                table: "Equities",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equities_Portfolios_PortfolioId",
                table: "Equities");

            migrationBuilder.DropColumn(
                name: "NumberHeld",
                table: "Equities");

            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "Equities");

            migrationBuilder.AlterColumn<int>(
                name: "PortfolioId",
                table: "Equities",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_UserId",
                table: "Portfolios",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equities_Portfolios_PortfolioId",
                table: "Equities",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_User_UserId",
                table: "Portfolios",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
