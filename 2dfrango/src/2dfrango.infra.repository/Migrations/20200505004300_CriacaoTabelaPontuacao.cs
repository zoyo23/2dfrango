using Microsoft.EntityFrameworkCore.Migrations;

namespace _2dfrango.infra.repository.Migrations
{
    public partial class CriacaoTabelaPontuacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pontuacao",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Moedas = table.Column<int>(nullable: false),
                    Diamantes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pontuacao", x => x.Email);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Autenticacao_Pontuacao_Email",
                table: "Autenticacao",
                column: "Email",
                principalTable: "Pontuacao",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autenticacao_Pontuacao_Email",
                table: "Autenticacao");

            migrationBuilder.DropTable(
                name: "Pontuacao");
        }
    }
}
