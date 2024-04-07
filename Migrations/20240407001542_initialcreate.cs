using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Centralita.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "costollamada",
                table: "llamadas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "destino",
                table: "llamadas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "duracion",
                table: "llamadas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "origen",
                table: "llamadas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "costollamada",
                table: "llamadas");

            migrationBuilder.DropColumn(
                name: "destino",
                table: "llamadas");

            migrationBuilder.DropColumn(
                name: "duracion",
                table: "llamadas");

            migrationBuilder.DropColumn(
                name: "origen",
                table: "llamadas");
        }
    }
}
