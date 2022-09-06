using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soccer.Shared.Migrations
{
    public partial class seededAdminfix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "928fb6b3-f09d-49ae-8346-7a8a1569ec86");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "teams",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 16, 39, 821, DateTimeKind.Local).AddTicks(3635),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 14, 4, 456, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "players",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 16, 39, 821, DateTimeKind.Local).AddTicks(2031),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 14, 4, 456, DateTimeKind.Local).AddTicks(3296));

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f9a7329-d5c4-46e0-99b5-0aa152c9da8f", "fe37ec234a480f030c83b2dfe456ac35df666cea98735c9aadd932fffcbaca8c", "411e12c8-d7b0-4fdb-8503-4e213a6a6281" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2022, 9, 6, 20, 14, 4, 456, DateTimeKind.Local).AddTicks(4775),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 16, 39, 821, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "players",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 14, 4, 456, DateTimeKind.Local).AddTicks(3296),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 16, 39, 821, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a5746ec-1709-46f9-be21-ca259a143f89",
                column: "ConcurrencyStamp",
                value: "091705f5-4f21-437a-acf3-af9f8f98d403");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "928fb6b3-f09d-49ae-8346-7a8a1569ec86", "b6064717-8100-4bdc-a6ed-9f506117573d", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a5746ec-1709-46f9-be21-ca259a143f89",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23b699b7-0be1-4a1f-822b-f2dd6729d164", null, "8c975d6e-1399-4ab1-86f9-3ae085ae7ca9" });
        }
    }
}
