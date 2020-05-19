using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace char_creation.Migrations
{
    public partial class LineageAtributtes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropColumn(
                name: "atributtesId",
                table: "Lineage");

            migrationBuilder.AddColumn<int>(
                name: "lineageAtributtesId",
                table: "Lineage",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LineageAtributtes",
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
                    table.PrimaryKey("PK_LineageAtributtes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lineage_lineageAtributtesId",
                table: "Lineage",
                column: "lineageAtributtesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lineage_LineageAtributtes_lineageAtributtesId",
                table: "Lineage",
                column: "lineageAtributtesId",
                principalTable: "LineageAtributtes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lineage_LineageAtributtes_lineageAtributtesId",
                table: "Lineage");

            migrationBuilder.DropTable(
                name: "LineageAtributtes");

            migrationBuilder.DropIndex(
                name: "IX_Lineage_lineageAtributtesId",
                table: "Lineage");

            migrationBuilder.DropColumn(
                name: "lineageAtributtesId",
                table: "Lineage");

            migrationBuilder.AddColumn<int>(
                name: "atributtesId",
                table: "Lineage",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lineage_atributtesId",
                table: "Lineage",
                column: "atributtesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lineage_Atributtes_atributtesId",
                table: "Lineage",
                column: "atributtesId",
                principalTable: "Atributtes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
