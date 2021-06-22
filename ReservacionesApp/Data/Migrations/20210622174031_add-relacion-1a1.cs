using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservacionesApp.Data.Migrations
{
    public partial class addrelacion1a1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Motociclista_Servicio_ServicioId",
                table: "Motociclista");

            migrationBuilder.DropIndex(
                name: "IX_Motociclista_ServicioId",
                table: "Motociclista");

            migrationBuilder.DropColumn(
                name: "ServicioId",
                table: "Motociclista");

            migrationBuilder.AddColumn<int>(
                name: "MotociclistaId",
                table: "Servicio",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_MotociclistaId",
                table: "Servicio",
                column: "MotociclistaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicio_Motociclista_MotociclistaId",
                table: "Servicio",
                column: "MotociclistaId",
                principalTable: "Motociclista",
                principalColumn: "MotociclistaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicio_Motociclista_MotociclistaId",
                table: "Servicio");

            migrationBuilder.DropIndex(
                name: "IX_Servicio_MotociclistaId",
                table: "Servicio");

            migrationBuilder.DropColumn(
                name: "MotociclistaId",
                table: "Servicio");

            migrationBuilder.AddColumn<int>(
                name: "ServicioId",
                table: "Motociclista",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
