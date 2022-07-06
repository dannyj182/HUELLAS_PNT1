using Microsoft.EntityFrameworkCore.Migrations;

namespace HUELLAS_PNT1.Migrations
{
    public partial class imagenesMascota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "Pets",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Pets");
        }
    }
}
