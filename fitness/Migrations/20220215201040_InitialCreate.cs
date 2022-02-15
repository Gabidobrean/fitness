using Microsoft.EntityFrameworkCore.Migrations;

namespace fitness.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Antrenor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeAntrenor = table.Column<string>(nullable: true),
                    PrenumeAntrenor = table.Column<string>(nullable: true),
                    Ziua = table.Column<string>(nullable: true),
                    Ora = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Antrenor", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Antrenor");
        }
    }
}
