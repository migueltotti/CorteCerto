using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CorteCerto.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeBarberAvailabilitytoValueObject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BarberAvailabilities_Barbers_BarberId",
                table: "BarberAvailabilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BarberAvailabilities",
                table: "BarberAvailabilities");

            migrationBuilder.DropIndex(
                name: "IX_BarberAvailabilities_BarberId",
                table: "BarberAvailabilities");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BarberAvailabilities");

            migrationBuilder.AlterColumn<string>(
                name: "DayOfWeek",
                table: "BarberAvailabilities",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BarberAvailabilities",
                table: "BarberAvailabilities",
                columns: new[] { "BarberId", "DayOfWeek" });

            migrationBuilder.AddForeignKey(
                name: "FK_BarberAvailabilities_Barbers_BarberId",
                table: "BarberAvailabilities",
                column: "BarberId",
                principalTable: "Barbers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BarberAvailabilities_Barbers_BarberId",
                table: "BarberAvailabilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BarberAvailabilities",
                table: "BarberAvailabilities");

            migrationBuilder.AlterColumn<int>(
                name: "DayOfWeek",
                table: "BarberAvailabilities",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BarberAvailabilities",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BarberAvailabilities",
                table: "BarberAvailabilities",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BarberAvailabilities_BarberId",
                table: "BarberAvailabilities",
                column: "BarberId");

            migrationBuilder.AddForeignKey(
                name: "FK_BarberAvailabilities_Barbers_BarberId",
                table: "BarberAvailabilities",
                column: "BarberId",
                principalTable: "Barbers",
                principalColumn: "Id");
        }
    }
}
