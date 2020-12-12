using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ReactHomePage.Migrations
{
    public partial class ContainersUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weather",
                table: "Weather");

            migrationBuilder.DropIndex(
                name: "IX_Weather_LayoutId",
                table: "Weather");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_LayoutId",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_News",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_LayoutId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "ContainerId",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "ComponentType",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "LayoutId",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Weather");

            migrationBuilder.DropColumn(
                name: "ContainerId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "ComponentType",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "LayoutId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "ContainerId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "ComponentType",
                table: "News");

            migrationBuilder.DropColumn(
                name: "LayoutId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "News");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Weather",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Stocks",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "News",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weather",
                table: "Weather",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_News",
                table: "News",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Weather",
                table: "Weather");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_News",
                table: "News");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Weather",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "ContainerId",
                table: "Weather",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "ComponentType",
                table: "Weather",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "LayoutId",
                table: "Weather",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Weather",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Stocks",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "ContainerId",
                table: "Stocks",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "ComponentType",
                table: "Stocks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "LayoutId",
                table: "Stocks",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Stocks",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "News",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "ContainerId",
                table: "News",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "ComponentType",
                table: "News",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "LayoutId",
                table: "News",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "News",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weather",
                table: "Weather",
                column: "ContainerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks",
                column: "ContainerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_News",
                table: "News",
                column: "ContainerId");

            migrationBuilder.CreateTable(
                name: "Layout",
                columns: table => new
                {
                    LayoutId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    H = table.Column<int>(type: "integer", nullable: false),
                    I = table.Column<string>(type: "text", nullable: true),
                    W = table.Column<int>(type: "integer", nullable: false),
                    X = table.Column<int>(type: "integer", nullable: false),
                    Y = table.Column<int>(type: "integer", nullable: false)
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
    }
}
