using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EleicaoCipa.Migrations
{
    public partial class DefineNomeNasTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Usuarios",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Discurso",
                table: "Candidatos",
                newName: "discurso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Usuarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "discurso",
                table: "Candidatos",
                newName: "Discurso");
        }
    }
}
