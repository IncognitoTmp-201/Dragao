using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DragaoApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoBaratas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PatinhasFofas",
                table: "Baratas",
                newName: "Patinhas");

            migrationBuilder.RenameColumn(
                name: "AntenasFofas",
                table: "Baratas",
                newName: "Antenas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Patinhas",
                table: "Baratas",
                newName: "PatinhasFofas");

            migrationBuilder.RenameColumn(
                name: "Antenas",
                table: "Baratas",
                newName: "AntenasFofas");
        }
    }
}
