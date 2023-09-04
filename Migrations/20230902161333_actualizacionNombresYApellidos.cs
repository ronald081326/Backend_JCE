using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendApi.Migrations
{
    /// <inheritdoc />
    public partial class actualizacionNombresYApellidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Profesores",
                newName: "Nombres");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Estudiantes",
                newName: "Nombres");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Estudiantes",
                newName: "Apellidos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombres",
                table: "Profesores",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Nombres",
                table: "Estudiantes",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Apellidos",
                table: "Estudiantes",
                newName: "Apellido");
        }
    }
}
