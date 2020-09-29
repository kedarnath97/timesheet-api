using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace timesheet.data.Migrations
{
    public partial class UpdatingVirtualForiegnKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeWorkTimeEntryId",
                table: "Tasks",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmployeeTaskHours",
                columns: table => new
                {
                    EntryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RecordDate = table.Column<DateTime>(nullable: false),
                    EmployeeCode = table.Column<string>(nullable: false),
                    TaskId = table.Column<int>(nullable: false),
                    TaskHours = table.Column<double>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTaskHours", x => x.EntryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_EmployeeWorkTimeEntryId",
                table: "Tasks",
                column: "EmployeeWorkTimeEntryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_EmployeeTaskHours_EmployeeWorkTimeEntryId",
                table: "Tasks",
                column: "EmployeeWorkTimeEntryId",
                principalTable: "EmployeeTaskHours",
                principalColumn: "EntryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_EmployeeTaskHours_EmployeeWorkTimeEntryId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "EmployeeTaskHours");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_EmployeeWorkTimeEntryId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "EmployeeWorkTimeEntryId",
                table: "Tasks");
        }
    }
}
