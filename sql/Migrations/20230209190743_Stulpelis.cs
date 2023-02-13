using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aviabaze.Migrations
{
    /// <inheritdoc />
    public partial class Stulpelis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Avions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Avions");
        }
    }
}
