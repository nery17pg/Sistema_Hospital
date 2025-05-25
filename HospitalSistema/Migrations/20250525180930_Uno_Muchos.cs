using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalSistema.Migrations
{
    /// <inheritdoc />
    public partial class Uno_Muchos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Medicos_MedicoId",
                table: "Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_Consulta_Pacientes_PacienteId",
                table: "Consulta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consulta",
                table: "Consulta");

            migrationBuilder.RenameTable(
                name: "Consulta",
                newName: "Consultas");

            migrationBuilder.RenameIndex(
                name: "IX_Consulta_PacienteId",
                table: "Consultas",
                newName: "IX_Consultas_PacienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Consulta_MedicoId",
                table: "Consultas",
                newName: "IX_Consultas_MedicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consultas",
                table: "Consultas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Medicos_MedicoId",
                table: "Consultas",
                column: "MedicoId",
                principalTable: "Medicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Pacientes_PacienteId",
                table: "Consultas",
                column: "PacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Medicos_MedicoId",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Pacientes_PacienteId",
                table: "Consultas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consultas",
                table: "Consultas");

            migrationBuilder.RenameTable(
                name: "Consultas",
                newName: "Consulta");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_PacienteId",
                table: "Consulta",
                newName: "IX_Consulta_PacienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_MedicoId",
                table: "Consulta",
                newName: "IX_Consulta_MedicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consulta",
                table: "Consulta",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Medicos_MedicoId",
                table: "Consulta",
                column: "MedicoId",
                principalTable: "Medicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consulta_Pacientes_PacienteId",
                table: "Consulta",
                column: "PacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
