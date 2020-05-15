using Microsoft.EntityFrameworkCore.Migrations;

namespace char_creation.Migrations
{
    public partial class addinfoteste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "del",
                table: "Character",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "del",
                table: "Character");
        }
    }
}
