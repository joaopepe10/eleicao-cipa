using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EleicaoCipa.Migrations
{
    public partial class VotoEleicaoOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votos_Eleicoes_EleicaoId",
                table: "Votos");

            migrationBuilder.AlterColumn<int>(
                name: "EleicaoId",
                table: "Votos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Votos_Eleicoes_EleicaoId",
                table: "Votos",
                column: "EleicaoId",
                principalTable: "Eleicoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votos_Eleicoes_EleicaoId",
                table: "Votos");

            migrationBuilder.AlterColumn<int>(
                name: "EleicaoId",
                table: "Votos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Votos_Eleicoes_EleicaoId",
                table: "Votos",
                column: "EleicaoId",
                principalTable: "Eleicoes",
                principalColumn: "Id");
        }
    }
}
