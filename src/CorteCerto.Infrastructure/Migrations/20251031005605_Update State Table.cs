using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorteCerto.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Acronym",
                table: "States",
                type: "character varying(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateIndex(
                name: "IX_States_Name_Acronym",
                table: "States",
                columns: new[] { "Name", "Acronym" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_States_Name_Acronym",
                table: "States");

            migrationBuilder.AlterColumn<string>(
                name: "Acronym",
                table: "States",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(2)",
                oldMaxLength: 2);
        }
    }
}
