using Microsoft.EntityFrameworkCore.Migrations;

namespace SalonWebApi.Migrations
{
    public partial class ChangingVehicleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_CarShowrooms_CarShowroomId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_CarShowroomId",
                table: "Vehicles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CarShowroomId",
                table: "Vehicles",
                column: "CarShowroomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_CarShowrooms_CarShowroomId",
                table: "Vehicles",
                column: "CarShowroomId",
                principalTable: "CarShowrooms",
                principalColumn: "CarShowroomId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
