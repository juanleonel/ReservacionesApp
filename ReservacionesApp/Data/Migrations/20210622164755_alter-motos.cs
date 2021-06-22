using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservacionesApp.Data.Migrations
{
    public partial class altermotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Motociclista",
                table: "Motociclista");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Motociclista");

            migrationBuilder.AddColumn<int>(
                name: "MotociclistaId",
                table: "Motociclista",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ServicioId",
                table: "Motociclista",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Motociclista",
                table: "Motociclista",
                column: "MotociclistaId");

            migrationBuilder.CreateTable(
                name: "Servicio",
                columns: table => new
                {
                    ServicioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaAlta = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio", x => x.ServicioId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Motociclista_ServicioId",
                table: "Motociclista",
                column: "ServicioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Motociclista_Servicio_ServicioId",
                table: "Motociclista",
                column: "ServicioId",
                principalTable: "Servicio",
                principalColumn: "ServicioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Motociclista_Servicio_ServicioId",
                table: "Motociclista");

            migrationBuilder.DropTable(
                name: "Servicio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Motociclista",
                table: "Motociclista");

            migrationBuilder.DropIndex(
                name: "IX_Motociclista_ServicioId",
                table: "Motociclista");

            migrationBuilder.DropColumn(
                name: "MotociclistaId",
                table: "Motociclista");

            migrationBuilder.DropColumn(
                name: "ServicioId",
                table: "Motociclista");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Motociclista",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Motociclista",
                table: "Motociclista",
                column: "Id");
        }
    }
}
