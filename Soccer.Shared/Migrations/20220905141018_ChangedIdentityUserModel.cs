using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soccer.Shared.Migrations
{
    public partial class ChangedIdentityUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Nationality",
                table: "AspNetUsers",
                newName: "FullName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Team",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 16, 10, 17, 843, DateTimeKind.Local).AddTicks(4104),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 5, 15, 18, 2, 149, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Player",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 16, 10, 17, 843, DateTimeKind.Local).AddTicks(2952),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 5, 15, 18, 2, 149, DateTimeKind.Local).AddTicks(7681));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "AspNetUsers",
                newName: "Nationality");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Team",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 15, 18, 2, 149, DateTimeKind.Local).AddTicks(9603),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 5, 16, 10, 17, 843, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Player",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 15, 18, 2, 149, DateTimeKind.Local).AddTicks(7681),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 5, 16, 10, 17, 843, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "AspNetUsers",
                type: "longblob",
                nullable: false);
        }
    }
}
