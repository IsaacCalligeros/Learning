using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ReactHomePage.Migrations
{
    public partial class ContainersMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ControlId",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "H",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "W",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "X",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "Y",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "ControlId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "H",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "W",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "X",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "Y",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "ControlId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "H",
                table: "News");

            migrationBuilder.DropColumn(
                name: "W",
                table: "News");

            migrationBuilder.DropColumn(
                name: "X",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Y",
                table: "News");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Weather",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ComponentType",
                table: "Weather",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "LayoutId",
                table: "Weather",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Stocks",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ComponentType",
                table: "Stocks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "LayoutId",
                table: "Stocks",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "News",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ComponentType",
                table: "News",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "LayoutId",
                table: "News",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Layout",
                columns: table => new
                {
                    LayoutId = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    I = table.Column<string>(nullable: true),
                    H = table.Column<int>(nullable: false),
                    W = table.Column<int>(nullable: false),
                    X = table.Column<int>(nullable: false),
                    Y = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Layout", x => x.LayoutId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Weather_LayoutId",
                table: "Weather",
                column: "LayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_LayoutId",
                table: "Stocks",
                column: "LayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_News_LayoutId",
                table: "News",
                column: "LayoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Layout_LayoutId",
                table: "News",
                column: "LayoutId",
                principalTable: "Layout",
                principalColumn: "LayoutId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Layout_LayoutId",
                table: "Stocks",
                column: "LayoutId",
                principalTable: "Layout",
                principalColumn: "LayoutId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Weather_Layout_LayoutId",
                table: "Weather",
                column: "LayoutId",
                principalTable: "Layout",
                principalColumn: "LayoutId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Layout_LayoutId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Layout_LayoutId",
                table: "Stocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Weather_Layout_LayoutId",
                table: "Weather");

            migrationBuilder.DropTable(
                name: "Layout");

            migrationBuilder.DropIndex(
                name: "IX_Weather_LayoutId",
                table: "Weather");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_LayoutId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_News_LayoutId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "ComponentType",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "LayoutId",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "ComponentType",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "LayoutId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "ComponentType",
                table: "News");

            migrationBuilder.DropColumn(
                name: "LayoutId",
                table: "News");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Weather",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ControlId",
                table: "Weather",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "H",
                table: "Weather",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "W",
                table: "Weather",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "X",
                table: "Weather",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Y",
                table: "Weather",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Stocks",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ControlId",
                table: "Stocks",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "H",
                table: "Stocks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "W",
                table: "Stocks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "X",
                table: "Stocks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Y",
                table: "Stocks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "News",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ControlId",
                table: "News",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "H",
                table: "News",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "W",
                table: "News",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "X",
                table: "News",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Y",
                table: "News",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
