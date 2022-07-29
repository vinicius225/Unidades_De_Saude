using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unidades_De_Saude.Data.Migrations
{
    public partial class AddNewsColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "situation",
                table: "medico_especialidade",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "situation",
                table: "Medico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "situation",
                table: "Especialidade",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "situation",
                table: "medico_especialidade");

            migrationBuilder.DropColumn(
                name: "situation",
                table: "Medico");

            migrationBuilder.DropColumn(
                name: "situation",
                table: "Especialidade");
        }
    }
}
