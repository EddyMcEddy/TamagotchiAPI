using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TamagotchiAPI.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PetsId",
                table: "Scolding",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PetsId",
                table: "Playtime",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PetsId",
                table: "Feeding",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Scolding_PetsId",
                table: "Scolding",
                column: "PetsId");

            migrationBuilder.CreateIndex(
                name: "IX_Playtime_PetsId",
                table: "Playtime",
                column: "PetsId");

            migrationBuilder.CreateIndex(
                name: "IX_Feeding_PetsId",
                table: "Feeding",
                column: "PetsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feeding_Pets_PetsId",
                table: "Feeding",
                column: "PetsId",
                principalTable: "Pets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Playtime_Pets_PetsId",
                table: "Playtime",
                column: "PetsId",
                principalTable: "Pets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scolding_Pets_PetsId",
                table: "Scolding",
                column: "PetsId",
                principalTable: "Pets",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feeding_Pets_PetsId",
                table: "Feeding");

            migrationBuilder.DropForeignKey(
                name: "FK_Playtime_Pets_PetsId",
                table: "Playtime");

            migrationBuilder.DropForeignKey(
                name: "FK_Scolding_Pets_PetsId",
                table: "Scolding");

            migrationBuilder.DropIndex(
                name: "IX_Scolding_PetsId",
                table: "Scolding");

            migrationBuilder.DropIndex(
                name: "IX_Playtime_PetsId",
                table: "Playtime");

            migrationBuilder.DropIndex(
                name: "IX_Feeding_PetsId",
                table: "Feeding");

            migrationBuilder.DropColumn(
                name: "PetsId",
                table: "Scolding");

            migrationBuilder.DropColumn(
                name: "PetsId",
                table: "Playtime");

            migrationBuilder.DropColumn(
                name: "PetsId",
                table: "Feeding");
        }
    }
}
