using Microsoft.EntityFrameworkCore.Migrations;

namespace char_creation.Migrations
{
    public partial class removeinfoteste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "del",
                table: "Character");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "del",
                table: "Character",
                type: "text",
                nullable: true);
        }
    }
}
