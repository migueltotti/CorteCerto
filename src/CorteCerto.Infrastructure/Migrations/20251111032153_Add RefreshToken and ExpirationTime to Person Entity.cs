using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorteCerto.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRefreshTokenandExpirationTimetoPersonEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "People",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiresAt",
                table: "People",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "People");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiresAt",
                table: "People");
        }
    }
}
