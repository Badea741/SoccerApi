using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soccer.Shared.Migrations
{
    public partial class seededAdminfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe4275c4-7733-4fab-b35c-bb82feb806c8");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "teams",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 14, 4, 456, DateTimeKind.Local).AddTicks(4775),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 11, 29, 507, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "players",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 14, 4, 456, DateTimeKind.Local).AddTicks(3296),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 11, 29, 507, DateTimeKind.Local).AddTicks(2436));

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "23b699b7-0be1-4a1f-822b-f2dd6729d164", "MOHAMMED30981710@F-ENG.TANTA.EDU.EG", "BADEA", "8c975d6e-1399-4ab1-86f9-3ae085ae7ca9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2022, 9, 6, 20, 11, 29, 507, DateTimeKind.Local).AddTicks(3574),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 14, 4, 456, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "players",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 11, 29, 507, DateTimeKind.Local).AddTicks(2436),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 14, 4, 456, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a5746ec-1709-46f9-be21-ca259a143f89",
                column: "ConcurrencyStamp",
                value: "b9c014a9-368e-4115-9b63-b889c1ce70f3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe4275c4-7733-4fab-b35c-bb82feb806c8", "e98ad6f0-c013-4f5b-b437-ed4d91da12fb", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a5746ec-1709-46f9-be21-ca259a143f89",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "SecurityStamp" },
                values: new object[] { "630377c4-594d-42b8-a7e8-6b9c91d70264", null, null, "99a24132-5530-4d42-90f1-94ebb1eb400f" });
        }
    }
}
