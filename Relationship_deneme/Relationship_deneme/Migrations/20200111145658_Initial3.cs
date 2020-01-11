using Microsoft.EntityFrameworkCore.Migrations;

namespace Relationship_deneme.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Authors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Authors",
                nullable: false,
                defaultValue: 0);
        }
    }
}
