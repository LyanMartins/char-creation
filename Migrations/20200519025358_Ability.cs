using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace char_creation.Migrations
{
    public partial class Ability : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AbilityId",
                table: "Character",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ability",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    cost = table.Column<int>(nullable: false),
                    type = table.Column<string>(nullable: true),
                    CharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ability_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Character_AbilityId",
                table: "Character",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Ability_CharacterId",
                table: "Ability",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Ability_AbilityId",
                table: "Character",
                column: "AbilityId",
                principalTable: "Ability",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Character_Ability_AbilityId",
                table: "Character");

            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropIndex(
                name: "IX_Character_AbilityId",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "AbilityId",
                table: "Character");
        }
    }
}
