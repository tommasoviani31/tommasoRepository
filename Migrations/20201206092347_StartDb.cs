using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TMmvc.Migrations
{
    public partial class StartDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    IsExternal = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ActivityTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Start = table.Column<DateTime>(type: "TEXT", nullable: false),
                    End = table.Column<DateTime>(type: "TEXT", nullable: false),
                    State = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activity_ActivityType_ActivityTypeId",
                        column: x => x.ActivityTypeId,
                        principalTable: "ActivityType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActivityType",
                columns: new[] { "Id", "IsExternal", "Name" },
                values: new object[] { 1, false, "Generico" });

            migrationBuilder.InsertData(
                table: "ActivityType",
                columns: new[] { "Id", "IsExternal", "Name" },
                values: new object[] { 2, false, "Sport" });

            migrationBuilder.InsertData(
                table: "ActivityType",
                columns: new[] { "Id", "IsExternal", "Name" },
                values: new object[] { 3, false, "Consulenza" });

            migrationBuilder.InsertData(
                table: "ActivityType",
                columns: new[] { "Id", "IsExternal", "Name" },
                values: new object[] { 4, false, "Studio" });

            migrationBuilder.InsertData(
                table: "ActivityType",
                columns: new[] { "Id", "IsExternal", "Name" },
                values: new object[] { 5, false, "Casa" });

            migrationBuilder.CreateIndex(
                name: "IX_Activity_ActivityTypeId",
                table: "Activity",
                column: "ActivityTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "ActivityType");
        }
    }
}
