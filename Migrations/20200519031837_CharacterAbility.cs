using Microsoft.EntityFrameworkCore.Migrations;

namespace char_creation.Migrations
{
    public partial class CharacterAbility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AbilityId",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Ability");

            migrationBuilder.CreateTable(
                name: "CharacterAbility",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    characterId = table.Column<int>(nullable: false),
                    abilityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterAbility", x => new { x.Id, x.abilityId, x.characterId });
                    table.ForeignKey(
                        name: "FK_CharacterAbility_Ability_abilityId",
                        column: x => x.abilityId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterAbility_Character_characterId",
                        column: x => x.characterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAbility_abilityId",
                table: "CharacterAbility",
                column: "abilityId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAbility_characterId",
                table: "CharacterAbility",
                column: "characterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterAbility");

            migrationBuilder.AddColumn<int>(
                name: "AbilityId",
                table: "Character",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacterId",
                table: "Ability",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Character_AbilityId",
                table: "Character",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Ability_CharacterId",
                table: "Ability",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ability_Character_CharacterId",
                table: "Ability",
                column: "CharacterId",
                principalTable: "Character",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Ability_AbilityId",
                table: "Character",
                column: "AbilityId",
                principalTable: "Ability",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
