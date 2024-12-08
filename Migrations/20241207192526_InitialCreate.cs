using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDIGESETT.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cedula = table.Column<string>(type: "TEXT", nullable: false),
                    Clave = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Multas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cedula = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Concepto = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Coordenadas = table.Column<string>(type: "TEXT", nullable: false),
                    Foto = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agentes");

            migrationBuilder.DropTable(
                name: "Multas");
        }
    }
}
