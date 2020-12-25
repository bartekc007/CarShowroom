using Microsoft.EntityFrameworkCore.Migrations;

namespace SalonWebApi.Migrations
{
    public partial class ChangingCarShowRoomContainerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarShowrooms_CarShowroomContainers_CarShowroomContainerId",
                table: "CarShowrooms");

            migrationBuilder.DropIndex(
                name: "IX_CarShowrooms_CarShowroomContainerId",
                table: "CarShowrooms");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CarShowrooms_CarShowroomContainerId",
                table: "CarShowrooms",
                column: "CarShowroomContainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarShowrooms_CarShowroomContainers_CarShowroomContainerId",
                table: "CarShowrooms",
                column: "CarShowroomContainerId",
                principalTable: "CarShowroomContainers",
                principalColumn: "CarShowroomContainerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
