using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalonWebApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarShowroomContainers",
                columns: table => new
                {
                    CarShowroomContainerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarShowroomContainers", x => x.CarShowroomContainerId);
                });

            migrationBuilder.CreateTable(
                name: "ToDoItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarShowrooms",
                columns: table => new
                {
                    CarShowroomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxCapacity = table.Column<int>(type: "int", nullable: false),
                    CarShowroomContainerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarShowrooms", x => x.CarShowroomId);
                    table.ForeignKey(
                        name: "FK_CarShowrooms_CarShowroomContainers_CarShowroomContainerId",
                        column: x => x.CarShowroomContainerId,
                        principalTable: "CarShowroomContainers",
                        principalColumn: "CarShowroomContainerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalonId = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    value = table.Column<double>(type: "float", nullable: false),
                    CarShowroomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Ratings_CarShowrooms_CarShowroomId",
                        column: x => x.CarShowroomId,
                        principalTable: "CarShowrooms",
                        principalColumn: "CarShowroomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ProductionYear = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<double>(type: "float", nullable: false),
                    EngineCapacity = table.Column<double>(type: "float", nullable: false),
                    SalonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Booked = table.Column<bool>(type: "bit", nullable: false),
                    CarShowroomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicles_CarShowrooms_CarShowroomId",
                        column: x => x.CarShowroomId,
                        principalTable: "CarShowrooms",
                        principalColumn: "CarShowroomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarShowrooms_CarShowroomContainerId",
                table: "CarShowrooms",
                column: "CarShowroomContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_CarShowroomId",
                table: "Ratings",
                column: "CarShowroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CarShowroomId",
                table: "Vehicles",
                column: "CarShowroomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "ToDoItems");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "CarShowrooms");

            migrationBuilder.DropTable(
                name: "CarShowroomContainers");
        }
    }
}
