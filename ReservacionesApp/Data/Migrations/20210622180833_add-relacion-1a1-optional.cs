using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservacionesApp.Data.Migrations
{
    public partial class addrelacion1a1optional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicio_Motociclista_MotociclistaId",
                table: "Servicio");

            migrationBuilder.DropIndex(
                name: "IX_Servicio_MotociclistaId",
                table: "Servicio");

            migrationBuilder.AlterColumn<int>(
                name: "MotociclistaId",
                table: "Servicio",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_MotociclistaId",
                table: "Servicio",
                column: "MotociclistaId",
                unique: true,
                filter: "[MotociclistaId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicio_Motociclista_MotociclistaId",
                table: "Servicio",
                column: "MotociclistaId",
                principalTable: "Motociclista",
                principalColumn: "MotociclistaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicio_Motociclista_MotociclistaId",
                table: "Servicio");

            migrationBuilder.DropIndex(
                name: "IX_Servicio_MotociclistaId",
                table: "Servicio");

            migrationBuilder.AlterColumn<int>(
                name: "MotociclistaId",
                table: "Servicio",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
    }
}
