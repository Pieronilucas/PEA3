using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendamentoEventos.Migrations
{
    /// <inheritdoc />
    public partial class MudandoTabelaEventos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantidadeIngressosDisponiveis",
                table: "Eventos");

            migrationBuilder.AddColumn<string>(
                name: "Artista",
                table: "Eventos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Eventos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Eventos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Artista",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Eventos");

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeIngressosDisponiveis",
                table: "Eventos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
