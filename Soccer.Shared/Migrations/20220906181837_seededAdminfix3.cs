using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soccer.Shared.Migrations
{
    public partial class seededAdminfix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acc71933-7d7a-494b-8454-79c2ef5069f6");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "teams",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 18, 37, 143, DateTimeKind.Local).AddTicks(2376),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 16, 39, 821, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "players",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 18, 37, 143, DateTimeKind.Local).AddTicks(1054),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 16, 39, 821, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a5746ec-1709-46f9-be21-ca259a143f89",
                column: "ConcurrencyStamp",
                value: "36a700ba-6ccc-4208-81ab-11a01c66c4a3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbac8c23-24bf-4261-aaa7-520700744484", "50743c61-5d4a-47f4-bafc-8d40ae36770a", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a5746ec-1709-46f9-be21-ca259a143f89",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b6df03fe-f567-452d-b337-a1f9b6b85325", "2704bb30-ffd7-4f26-9f87-4088a3b96488" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbac8c23-24bf-4261-aaa7-520700744484");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "teams",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 16, 39, 821, DateTimeKind.Local).AddTicks(3635),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 18, 37, 143, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "players",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 16, 39, 821, DateTimeKind.Local).AddTicks(2031),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 18, 37, 143, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a5746ec-1709-46f9-be21-ca259a143f89",
                column: "ConcurrencyStamp",
                value: "46c573c9-f5ac-4abf-9992-2d2e86b79671");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "acc71933-7d7a-494b-8454-79c2ef5069f6", "b29145db-ad70-4320-81cf-c5bd8b6cefe2", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a5746ec-1709-46f9-be21-ca259a143f89",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2f9a7329-d5c4-46e0-99b5-0aa152c9da8f", "411e12c8-d7b0-4fdb-8503-4e213a6a6281" });
        }
    }
}
