using Microsoft.EntityFrameworkCore.Migrations;

namespace _2dfrango.infra.repository.Migrations
{
    public partial class AlteracaoTabelaAutenticacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Autenticacao",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Autenticacao");
        }
    }
}
