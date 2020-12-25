using Microsoft.EntityFrameworkCore.Migrations;

namespace SalonWebApi.Migrations
{
    public partial class DeleteToDoModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_CarShowrooms_CarShowroomId",
                table: "Ratings");

            migrationBuilder.DropTable(
                name: "ToDoItems");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_CarShowroomId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "CarShowroomId",
                table: "Ratings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarShowroomId",
                table: "Ratings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ToDoItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoItems", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_CarShowroomId",
                table: "Ratings",
                column: "CarShowroomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_CarShowrooms_CarShowroomId",
                table: "Ratings",
                column: "CarShowroomId",
                principalTable: "CarShowrooms",
                principalColumn: "CarShowroomId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
