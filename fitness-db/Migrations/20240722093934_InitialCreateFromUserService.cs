using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fitness_db.Migrations
{
    public partial class InitialCreateFromUserService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "nutritions",
                columns: table => new
                {
                    NutritionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NutritionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<float>(type: "real", nullable: false),
                    Protein = table.Column<float>(type: "real", nullable: false),
                    Carbs = table.Column<float>(type: "real", nullable: false),
                    Fat = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nutritions", x => x.NutritionID);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "workouts",
                columns: table => new
                {
                    WorkoutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkoutName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    CaloriesBurned = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workouts", x => x.WorkoutID);
                });

            migrationBuilder.CreateTable(
                name: "progresses",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ProgressID = table.Column<int>(type: "int", nullable: false),
                    ProgressDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    CaloriesConsumed = table.Column<float>(type: "real", nullable: false),
                    CaloriesBurned = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_progresses", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_progresses_users_UserID",
                        column: x => x.UserID,
                        principalTable: "users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userNutritions",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    NutritionID = table.Column<int>(type: "int", nullable: false),
                    UserNutritionID = table.Column<int>(type: "int", nullable: false),
                    UserNutritionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userNutritions", x => new { x.UserID, x.NutritionID });
                    table.ForeignKey(
                        name: "FK_userNutritions_nutritions_NutritionID",
                        column: x => x.NutritionID,
                        principalTable: "nutritions",
                        principalColumn: "NutritionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userNutritions_users_UserID",
                        column: x => x.UserID,
                        principalTable: "users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userWorkouts",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    WorkoutID = table.Column<int>(type: "int", nullable: false),
                    UserWorkoutID = table.Column<int>(type: "int", nullable: false),
                    UserWorkoutDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userWorkouts", x => new { x.UserID, x.WorkoutID });
                    table.ForeignKey(
                        name: "FK_userWorkouts_users_UserID",
                        column: x => x.UserID,
                        principalTable: "users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userWorkouts_workouts_WorkoutID",
                        column: x => x.WorkoutID,
                        principalTable: "workouts",
                        principalColumn: "WorkoutID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_userNutritions_NutritionID",
                table: "userNutritions",
                column: "NutritionID");

            migrationBuilder.CreateIndex(
                name: "IX_userWorkouts_WorkoutID",
                table: "userWorkouts",
                column: "WorkoutID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "progresses");

            migrationBuilder.DropTable(
                name: "userNutritions");

            migrationBuilder.DropTable(
                name: "userWorkouts");

            migrationBuilder.DropTable(
                name: "nutritions");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "workouts");
        }
    }
}
