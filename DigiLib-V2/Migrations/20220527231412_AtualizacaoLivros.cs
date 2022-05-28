using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DigiLibV2.Migrations
{
    public partial class AtualizacaoLivros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LIVROS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "text", nullable: true),
                    Autor = table.Column<string>(type: "text", nullable: true),
                    Editora = table.Column<string>(type: "text", nullable: true),
                    Ano_Lancamento = table.Column<int>(type: "int", nullable: false),
                    Edicao = table.Column<int>(type: "int", nullable: false),
                    Palavra_Chave = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIVROS", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LIVROS");
        }
    }
}
