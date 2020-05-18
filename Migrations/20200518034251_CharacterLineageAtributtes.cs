using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace char_creation.Migrations
{
    public partial class CharacterLineageAtributtes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "characterLineageId",
                table: "Character",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Atributtes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    force = table.Column<int>(nullable: false),
                    agility = table.Column<int>(nullable: false),
                    physicist = table.Column<int>(nullable: false),
                    aura = table.Column<int>(nullable: false),
                    intellect = table.Column<int>(nullable: false),
                    perception = table.Column<int>(nullable: false),
                    charisma = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atributtes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lineage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    atributtesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lineage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lineage_Atributtes_atributtesId",
                        column: x => x.atributtesId,
                        principalTable: "Atributtes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterLineage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    lineageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterLineage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterLineage_Lineage_lineageId",
                        column: x => x.lineageId,
                        principalTable: "Lineage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Character_characterLineageId",
                table: "Character",
                column: "characterLineageId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterLineage_lineageId",
                table: "CharacterLineage",
                column: "lineageId");

            migrationBuilder.CreateIndex(
                name: "IX_Lineage_atributtesId",
                table: "Lineage",
                column: "atributtesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Character_CharacterLineage_characterLineageId",
                table: "Character",
                column: "characterLineageId",
                principalTable: "CharacterLineage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Character_CharacterLineage_characterLineageId",
                table: "Character");

            migrationBuilder.DropTable(
                name: "CharacterLineage");

            migrationBuilder.DropTable(
                name: "Lineage");

            migrationBuilder.DropTable(
                name: "Atributtes");

            migrationBuilder.DropIndex(
                name: "IX_Character_characterLineageId",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "characterLineageId",
                table: "Character");
        }
    }
}
