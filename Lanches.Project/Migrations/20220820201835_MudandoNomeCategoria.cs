using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanches.Project.Migrations
{
    public partial class MudandoNomeCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoriaName",
                table: "Categorias",
                newName: "CategoriaNome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoriaNome",
                table: "Categorias",
                newName: "CategoriaName");
        }
    }
}
