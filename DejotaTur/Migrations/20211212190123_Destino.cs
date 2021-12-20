using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DejotaTur.Migrations
{
    public partial class Destino : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dests",
                columns: table => new
                {
                    ID_Destino = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cidade = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    País = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Continente = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Aeroportos_IATA = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dests", x => x.ID_Destino);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dests");
        }
    }
}
