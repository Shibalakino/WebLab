using Microsoft.EntityFrameworkCore.Migrations;

namespace GameShop.Migrations.Game
{
    public partial class RemovedDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
