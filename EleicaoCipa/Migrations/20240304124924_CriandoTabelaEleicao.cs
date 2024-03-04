using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EleicaoCipa.Migrations
{
    public partial class CriandoTabelaEleicao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eleicoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    data_inicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    data_fim = table.Column<DateTime>(type: "datetime", nullable: false),
                    status = table.Column<sbyte>(type: "tinyint", nullable: false),
                    CandidatoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleicoes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_EleicaoId",
                table: "Candidatos",
                column: "EleicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidatos_Eleicoes_EleicaoId",
                table: "Candidatos",
                column: "EleicaoId",
                principalTable: "Eleicoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidatos_Eleicoes_EleicaoId",
                table: "Candidatos");

            migrationBuilder.DropTable(
                name: "Eleicoes");

            migrationBuilder.DropIndex(
                name: "IX_Candidatos_EleicaoId",
                table: "Candidatos");
        }
    }
}
