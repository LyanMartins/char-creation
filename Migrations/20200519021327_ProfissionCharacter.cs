using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace char_creation.Migrations
{
    public partial class ProfissionCharacter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "profissionId",
                table: "Character",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Profission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    acquisitionPoints = table.Column<int>(nullable: false),
                    penalizedGroups = table.Column<string>(nullable: true),
                    specializedSkills = table.Column<string>(nullable: true),
                    combatPoints = table.Column<int>(nullable: false),
                    characterLineageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profission_CharacterLineage_characterLineageId",
                        column: x => x.characterLineageId,
                        principalTable: "CharacterLineage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Character_profissionId",
                table: "Character",
                column: "profissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Profission_characterLineageId",
                table: "Profission",
                column: "characterLineageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Profission_profissionId",
                table: "Character",
                column: "profissionId",
                principalTable: "Profission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Character_Profission_profissionId",
                table: "Character");

            migrationBuilder.DropTable(
                name: "Profission");

            migrationBuilder.DropIndex(
                name: "IX_Character_profissionId",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "profissionId",
                table: "Character");
        }
    }
}
