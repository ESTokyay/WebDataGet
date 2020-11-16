using Microsoft.EntityFrameworkCore.Migrations;

namespace WDG.DataAccess.Migrations
{
    public partial class FirstTableCrete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kurData",
                columns: table => new
                {
                    kurID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DovizKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birim = table.Column<int>(type: "int", nullable: false),
                    DovizCinsi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DovizAlis = table.Column<double>(type: "float", nullable: false),
                    DovizSatis = table.Column<double>(type: "float", nullable: false),
                    EfektifAlis = table.Column<double>(type: "float", nullable: false),
                    EfektifSatis = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kurData", x => x.kurID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kurData");
        }
    }
}
