using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopTARpe25.Data.Migrations
{
    public partial class KindergartenFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Spaceships",
                newName: "GroupName");

            migrationBuilder.RenameColumn(
                name: "Classification",
                table: "Spaceships",
                newName: "ChildrenCount");

            migrationBuilder.RenameColumn(
                name: "BuildDate",
                table: "Spaceships",
                newName: "KindergartenName");

            migrationBuilder.RenameColumn(
                name: "Crew",
                table: "Spaceships",
                newName: "TeacherName");

            migrationBuilder.RenameColumn(
                name: "ModifiedAt",
                table: "Spaceships",
                newName: "UpdatedAt");

            migrationBuilder.AlterColumn<int>(
                name: "ChildrenCount",
                table: "Spaceships",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "KindergartenName",
                table: "Spaceships",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TeacherName",
                table: "Spaceships",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.DropColumn(
                name: "EnginePower",
                table: "Spaceships");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnginePower",
                table: "Spaceships",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ChildrenCount",
                table: "Spaceships",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "KindergartenName",
                table: "Spaceships",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherName",
                table: "Spaceships",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.RenameColumn(
                name: "GroupName",
                table: "Spaceships",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ChildrenCount",
                table: "Spaceships",
                newName: "Classification");

            migrationBuilder.RenameColumn(
                name: "KindergartenName",
                table: "Spaceships",
                newName: "BuildDate");

            migrationBuilder.RenameColumn(
                name: "TeacherName",
                table: "Spaceships",
                newName: "Crew");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Spaceships",
                newName: "ModifiedAt");
        }
    }
}
