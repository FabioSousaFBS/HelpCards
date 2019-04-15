using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpCards.Migrations
{
    public partial class AtualizarTabelaOS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataAbertura",
                table: "OrdemServicos",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAbertura",
                table: "OrdemServicos");
        }
    }
}
