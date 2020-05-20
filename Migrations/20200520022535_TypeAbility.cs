using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace char_creation.Migrations
{
    public partial class TypeAbility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "typeAbilityId",
                table: "Ability",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TypeAbility",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeAbility", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ability_typeAbilityId",
                table: "Ability",
                column: "typeAbilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ability_TypeAbility_typeAbilityId",
                table: "Ability",
                column: "typeAbilityId",
                principalTable: "TypeAbility",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ability_TypeAbility_typeAbilityId",
                table: "Ability");

            migrationBuilder.DropTable(
                name: "TypeAbility");

            migrationBuilder.DropIndex(
                name: "IX_Ability_typeAbilityId",
                table: "Ability");

            migrationBuilder.DropColumn(
                name: "typeAbilityId",
                table: "Ability");
        }
    }
}
