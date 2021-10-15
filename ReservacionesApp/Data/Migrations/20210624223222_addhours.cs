using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservacionesApp.Data.Migrations
{
    public partial class addhours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hora",
                table: "Servicio",
                maxLength: 10,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hora",
                table: "Servicio");
        }
    }
}
