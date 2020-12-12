using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ReactHomePage.Migrations
{
    public partial class ContainersUpdate7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Containers_Layout_LayoutId",
                table: "Containers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Layout",
                table: "Layout");

            migrationBuilder.DropIndex(
                name: "IX_Containers_LayoutId",
                table: "Containers");

            migrationBuilder.DropColumn(
                name: "LayoutId",
                table: "Layout");

            migrationBuilder.DropColumn(
                name: "LayoutId",
                table: "Containers");

            migrationBuilder.AlterColumn<string>(
                name: "I",
                table: "Layout",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LayoutI",
                table: "Containers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Layout",
                table: "Layout",
                column: "I");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_LayoutI",
                table: "Containers",
                column: "LayoutI");

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_Layout_LayoutI",
                table: "Containers",
                column: "LayoutI",
                principalTable: "Layout",
                principalColumn: "I",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Containers_Layout_LayoutI",
                table: "Containers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Layout",
                table: "Layout");

            migrationBuilder.DropIndex(
                name: "IX_Containers_LayoutI",
                table: "Containers");

            migrationBuilder.DropColumn(
                name: "LayoutI",
                table: "Containers");

            migrationBuilder.AlterColumn<string>(
                name: "I",
                table: "Layout",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<long>(
                name: "LayoutId",
                table: "Layout",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<long>(
                name: "LayoutId",
                table: "Containers",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Layout",
                table: "Layout",
                column: "LayoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_LayoutId",
                table: "Containers",
                column: "LayoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_Layout_LayoutId",
                table: "Containers",
                column: "LayoutId",
                principalTable: "Layout",
                principalColumn: "LayoutId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
