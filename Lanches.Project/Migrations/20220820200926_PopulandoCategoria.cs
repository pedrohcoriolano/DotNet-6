using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanches.Project.Migrations
{
    public partial class PopulandoCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName, Descricao) " 
                +"VALUES('Normal','lanche feito com ingredientes normais')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName, Descricao) "
                + "VALUES('Natural','lanche feito com ingredientes naturais e integrais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM categorias");
        }
    }
}
