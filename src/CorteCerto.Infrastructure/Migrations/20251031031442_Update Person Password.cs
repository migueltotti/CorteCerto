using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorteCerto.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePersonPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "People");

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "People",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "People");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "People",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }
    }
}
