using Microsoft.EntityFrameworkCore.Migrations;

namespace HUELLAS_PNT1.Migrations
{
    public partial class HUELLAS_PNT1ContextHuellasDatabaseContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adopters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    MascotaDeInteres = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adopters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    Tamanio = table.Column<int>(nullable: false),
                    Genero = table.Column<int>(nullable: false),
                    Vacunado = table.Column<bool>(nullable: false),
                    Castrado = table.Column<bool>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adopters");

            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
