using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EleicaoCipa.Migrations
{
    public partial class ValueDefaultDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "data_voto",
                table: "Votos",
                type: "datetime",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AddColumn<int>(
                name: "CandidatoId",
                table: "Votos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Votos_CandidatoId",
                table: "Votos",
                column: "CandidatoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Votos_Candidatos_CandidatoId",
                table: "Votos",
                column: "CandidatoId",
                principalTable: "Candidatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votos_Candidatos_CandidatoId",
                table: "Votos");

            migrationBuilder.DropIndex(
                name: "IX_Votos_CandidatoId",
                table: "Votos");

            migrationBuilder.DropColumn(
                name: "CandidatoId",
                table: "Votos");

            migrationBuilder.AlterColumn<DateTime>(
                name: "data_voto",
                table: "Votos",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "now()");
        }
    }
}
