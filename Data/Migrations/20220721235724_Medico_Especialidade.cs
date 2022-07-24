using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Unidades_De_Saude.Data.Migrations
{
    public partial class Medico_Especialidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "medico_especialidade",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_medico = table.Column<int>(type: "int", nullable: false),
                    id_especialidade = table.Column<int>(type: "int", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medico_especialidade", x => x.id);
                    table.ForeignKey(
                        name: "FK_medico_especialidade_Especialidade_id_especialidade",
                        column: x => x.id_especialidade,
                        principalTable: "Especialidade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medico_especialidade_Medico_id_medico",
                        column: x => x.id_medico,
                        principalTable: "Medico",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_medico_especialidade_id_especialidade",
                table: "medico_especialidade",
                column: "id_especialidade");

            migrationBuilder.CreateIndex(
                name: "IX_medico_especialidade_id_medico",
                table: "medico_especialidade",
                column: "id_medico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "medico_especialidade");
        }
    }
}
