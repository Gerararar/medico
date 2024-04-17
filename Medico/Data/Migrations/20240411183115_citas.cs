using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Medico.Migrations
{
    /// <inheritdoc />
    public partial class citas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Pacientes_PacienteID",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "NombreID",
                table: "Citas");

            migrationBuilder.AlterColumn<int>(
                name: "PacienteID",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Pacientes_PacienteID",
                table: "Citas",
                column: "PacienteID",
                principalTable: "Pacientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Pacientes_PacienteID",
                table: "Citas");

            migrationBuilder.AlterColumn<int>(
                name: "PacienteID",
                table: "Citas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "NombreID",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Pacientes_PacienteID",
                table: "Citas",
                column: "PacienteID",
                principalTable: "Pacientes",
                principalColumn: "ID");
        }
    }
}
