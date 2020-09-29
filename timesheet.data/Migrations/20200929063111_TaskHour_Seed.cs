using Microsoft.EntityFrameworkCore.Migrations;

namespace timesheet.data.Migrations
{
    public partial class TaskHour_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"USE [TimeSheet] 
    SET IDENTITY_INSERT[dbo].[EmployeeTaskHours] ON 
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(1, CAST(N'2020-09-27T00:00:00.0000000' AS DateTime2), N'68319', 4, 3, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(2, CAST(N'2020-09-28T00:00:00.0000000' AS DateTime2), N'68319', 4, 3, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(3, CAST(N'2020-09-29T00:00:00.0000000' AS DateTime2), N'68319', 4, 3, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(4, CAST(N'2020-09-30T00:00:00.0000000' AS DateTime2), N'68319', 4, 4, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(5, CAST(N'2020-10-01T00:00:00.0000000' AS DateTime2), N'68319', 4, 4, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(6, CAST(N'2020-10-02T00:00:00.0000000' AS DateTime2), N'68319', 4, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(7, CAST(N'2020-09-27T00:00:00.0000000' AS DateTime2), N'68319', 2, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(8, CAST(N'2020-09-28T00:00:00.0000000' AS DateTime2), N'68319', 2, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(9, CAST(N'2020-09-29T00:00:00.0000000' AS DateTime2), N'68319', 2, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(10, CAST(N'2020-09-30T00:00:00.0000000' AS DateTime2), N'68319', 2, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(11, CAST(N'2020-10-01T00:00:00.0000000' AS DateTime2), N'68319', 2, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(12, CAST(N'2020-10-02T00:00:00.0000000' AS DateTime2), N'68319', 2, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(13, CAST(N'2020-09-27T00:00:00.0000000' AS DateTime2), N'68319', 5, 3, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(14, CAST(N'2020-09-28T00:00:00.0000000' AS DateTime2), N'68319', 5, 3, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(15, CAST(N'2020-09-29T00:00:00.0000000' AS DateTime2), N'68319', 5, 3, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(16, CAST(N'2020-09-30T00:00:00.0000000' AS DateTime2), N'68319', 5, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(17, CAST(N'2020-10-01T00:00:00.0000000' AS DateTime2), N'68319', 5, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(18, CAST(N'2020-10-02T00:00:00.0000000' AS DateTime2), N'68319', 5, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(19, CAST(N'2020-10-03T00:00:00.0000000' AS DateTime2), N'68319', 4, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(20, CAST(N'2020-10-03T00:00:00.0000000' AS DateTime2), N'68319', 2, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(21, CAST(N'2020-10-03T00:00:00.0000000' AS DateTime2), N'68319', 5, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(22, CAST(N'2020-09-27T00:00:00.0000000' AS DateTime2), N'67832', 4, 6, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(23, CAST(N'2020-09-28T00:00:00.0000000' AS DateTime2), N'67832', 4, 6, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(24, CAST(N'2020-09-29T00:00:00.0000000' AS DateTime2), N'67832', 4, 6, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(25, CAST(N'2020-09-30T00:00:00.0000000' AS DateTime2), N'67832', 4, 6, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(26, CAST(N'2020-10-01T00:00:00.0000000' AS DateTime2), N'67832', 4, 6, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(27, CAST(N'2020-10-02T00:00:00.0000000' AS DateTime2), N'67832', 4, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(28, CAST(N'2020-10-03T00:00:00.0000000' AS DateTime2), N'67832', 4, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(29, CAST(N'2020-09-27T00:00:00.0000000' AS DateTime2), N'67832', 5, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(30, CAST(N'2020-09-28T00:00:00.0000000' AS DateTime2), N'67832', 5, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(31, CAST(N'2020-09-29T00:00:00.0000000' AS DateTime2), N'67832', 5, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(32, CAST(N'2020-09-30T00:00:00.0000000' AS DateTime2), N'67832', 5, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(33, CAST(N'2020-10-01T00:00:00.0000000' AS DateTime2), N'67832', 5, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(34, CAST(N'2020-10-02T00:00:00.0000000' AS DateTime2), N'67832', 5, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(35, CAST(N'2020-10-03T00:00:00.0000000' AS DateTime2), N'67832', 5, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(36, CAST(N'2020-09-27T00:00:00.0000000' AS DateTime2), N'69062', 4, 5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(37, CAST(N'2020-09-28T00:00:00.0000000' AS DateTime2), N'69062', 4, 5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(38, CAST(N'2020-09-29T00:00:00.0000000' AS DateTime2), N'69062', 4, 5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(39, CAST(N'2020-09-30T00:00:00.0000000' AS DateTime2), N'69062', 4, 5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(40, CAST(N'2020-10-01T00:00:00.0000000' AS DateTime2), N'69062', 4, 5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(41, CAST(N'2020-10-02T00:00:00.0000000' AS DateTime2), N'69062', 4, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(42, CAST(N'2020-10-03T00:00:00.0000000' AS DateTime2), N'69062', 4, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(43, CAST(N'2020-09-27T00:00:00.0000000' AS DateTime2), N'69062', 5, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(44, CAST(N'2020-09-28T00:00:00.0000000' AS DateTime2), N'69062', 5, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(45, CAST(N'2020-09-29T00:00:00.0000000' AS DateTime2), N'69062', 5, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(46, CAST(N'2020-09-30T00:00:00.0000000' AS DateTime2), N'69062', 5, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(47, CAST(N'2020-10-01T00:00:00.0000000' AS DateTime2), N'69062', 5, 2, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(48, CAST(N'2020-10-02T00:00:00.0000000' AS DateTime2), N'69062', 5, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(49, CAST(N'2020-10-03T00:00:00.0000000' AS DateTime2), N'69062', 5, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(50, CAST(N'2020-09-27T00:00:00.0000000' AS DateTime2), N'69062', 3, 0.5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(51, CAST(N'2020-09-28T00:00:00.0000000' AS DateTime2), N'69062', 3, 0.5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(52, CAST(N'2020-09-29T00:00:00.0000000' AS DateTime2), N'69062', 3, 0.5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(53, CAST(N'2020-09-30T00:00:00.0000000' AS DateTime2), N'69062', 3, 0.5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(54, CAST(N'2020-10-01T00:00:00.0000000' AS DateTime2), N'69062', 3, 0.5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(55, CAST(N'2020-10-02T00:00:00.0000000' AS DateTime2), N'69062', 3, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(56, CAST(N'2020-10-03T00:00:00.0000000' AS DateTime2), N'69062', 3, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(57, CAST(N'2020-09-27T00:00:00.0000000' AS DateTime2), N'69062', 2, 0.5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(58, CAST(N'2020-09-28T00:00:00.0000000' AS DateTime2), N'69062', 2, 0.5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(59, CAST(N'2020-09-29T00:00:00.0000000' AS DateTime2), N'69062', 2, 0.5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(60, CAST(N'2020-09-30T00:00:00.0000000' AS DateTime2), N'69062', 2, 0.5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(61, CAST(N'2020-10-01T00:00:00.0000000' AS DateTime2), N'69062', 2, 0.5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(62, CAST(N'2020-10-02T00:00:00.0000000' AS DateTime2), N'69062', 2, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(63, CAST(N'2020-10-03T00:00:00.0000000' AS DateTime2), N'69062', 2, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(64, CAST(N'2020-09-20T00:00:00.0000000' AS DateTime2), N'64989', 4, 5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(65, CAST(N'2020-09-21T00:00:00.0000000' AS DateTime2), N'64989', 4, 5, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(66, CAST(N'2020-09-22T00:00:00.0000000' AS DateTime2), N'64989', 4, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(67, CAST(N'2020-09-23T00:00:00.0000000' AS DateTime2), N'64989', 4, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(68, CAST(N'2020-09-24T00:00:00.0000000' AS DateTime2), N'64989', 4, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(69, CAST(N'2020-09-25T00:00:00.0000000' AS DateTime2), N'64989', 4, 0, NULL)
                    INSERT[dbo].[EmployeeTaskHours]([EntryId], [RecordDate], [EmployeeCode], [TaskId], [TaskHours], [Comments]) VALUES(70, CAST(N'2020-09-26T00:00:00.0000000' AS DateTime2), N'64989', 4, 0, NULL)

    SET IDENTITY_INSERT[dbo].[EmployeeTaskHours] OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
