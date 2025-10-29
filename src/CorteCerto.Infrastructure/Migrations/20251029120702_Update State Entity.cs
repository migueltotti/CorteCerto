using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorteCerto.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStateEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Acronym",
                table: "States",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Neighborhood",
                table: "Addresses",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acronym",
                table: "States");

            migrationBuilder.DropColumn(
                name: "Neighborhood",
                table: "Addresses");
        }
    }
}
