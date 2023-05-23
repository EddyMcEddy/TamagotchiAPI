using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TamagotchiAPI.Migrations
{
    public partial class AddLastInteraction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastPlayTime",
                table: "Playtime",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastInteraction",
                table: "Pets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastPlayTime",
                table: "Playtime");

            migrationBuilder.DropColumn(
                name: "LastInteraction",
                table: "Pets");
        }
    }
}
