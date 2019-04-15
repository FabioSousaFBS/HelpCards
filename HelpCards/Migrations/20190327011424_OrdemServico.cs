using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpCards.Migrations
{
    public partial class OrdemServico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdemServicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Municipio = table.Column<string>(nullable: true),
                    Provedor = table.Column<string>(nullable: true),
                    Situacao = table.Column<string>(nullable: true),
                    Problema = table.Column<string>(nullable: true),
                    Solucao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemServicos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdemServicos");
        }
    }
}
