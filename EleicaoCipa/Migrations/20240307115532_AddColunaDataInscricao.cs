using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EleicaoCipa.Migrations
{
    public partial class AddColunaDataInscricao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Usuarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "discurso",
                table: "Candidatos",
                newName: "Discurso");

            migrationBuilder.AddColumn<DateTime>(
                name: "data_inscricao",
                table: "Candidatos",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "data_inscricao",
                table: "Candidatos");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Usuarios",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Discurso",
                table: "Candidatos",
                newName: "discurso");
        }
    }
}
