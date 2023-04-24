using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DragaoApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicaoTabelaBarataETabelaDragao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Baratas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AntenasFofas = table.Column<int>(type: "INTEGER", nullable: false),
                    PatinhasFofas = table.Column<int>(type: "INTEGER", nullable: false),
                    Asinhas = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baratas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dragoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Cor = table.Column<string>(type: "TEXT", nullable: true),
                    Estado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dragoes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baratas");

            migrationBuilder.DropTable(
                name: "Dragoes");
        }
    }
}
