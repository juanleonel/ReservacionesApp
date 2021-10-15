using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservacionesApp.Data.Migrations
{
    public partial class deleteservicioAsignado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicio_ServicioAsignado_ServicioAsignadoId1",
                table: "Servicio");

            migrationBuilder.DropTable(
                name: "ServicioAsignado");

            migrationBuilder.DropIndex(
                name: "IX_Servicio_ServicioAsignadoId1",
                table: "Servicio");

            migrationBuilder.DropColumn(
                name: "ServicioAsignadoId",
                table: "Servicio");

            migrationBuilder.DropColumn(
                name: "ServicioAsignadoId1",
                table: "Servicio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServicioAsignadoId",
                table: "Servicio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServicioAsignadoId1",
                table: "Servicio",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ServicioAsignado",
                columns: table => new
                {
                    ServicioAsignadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicioAsignado", x => x.ServicioAsignadoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_ServicioAsignadoId1",
                table: "Servicio",
                column: "ServicioAsignadoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicio_ServicioAsignado_ServicioAsignadoId1",
                table: "Servicio",
                column: "ServicioAsignadoId1",
                principalTable: "ServicioAsignado",
                principalColumn: "ServicioAsignadoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
