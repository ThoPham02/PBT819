using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PBT819.Migrations
{
    /// <inheritdoc />
    public partial class updateSchema2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Person",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Person");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Person",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
