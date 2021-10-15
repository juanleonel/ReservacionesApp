using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservacionesApp.Data.Migrations
{
    public partial class quitandocamposservicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ocupado",
                table: "Servicio");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Servicio");

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Motociclista",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Motociclista");

            migrationBuilder.AddColumn<bool>(
                name: "Ocupado",
                table: "Servicio",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioId",
                table: "Servicio",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
