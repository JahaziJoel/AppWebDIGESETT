using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppDIGESETT.Migrations
{
    /// <inheritdoc />
    public partial class duro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Monto",
                table: "Multas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Agentes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Rol",
                table: "Agentes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Agentes",
                columns: new[] { "Id", "Activo", "Apellido", "Cedula", "Clave", "Nombre", "Rol" },
                values: new object[,]
                {
                    { 1, true, "", "12345678", "clave123", "Agente 1", "Agente" },
                    { 2, true, "", "87654321", "clave456", "Oficina Central", "Oficina" },
                    { 3, true, "", "adamix", "estoesfacil", "Administrador", "Administrador" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agentes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Agentes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Agentes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Monto",
                table: "Multas");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Agentes");

            migrationBuilder.DropColumn(
                name: "Rol",
                table: "Agentes");
        }
    }
}
