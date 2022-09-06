using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soccer.Shared.Migrations
{
    public partial class seededAdminfix5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23065ef5-ffee-4695-9989-6f4dce43dacb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7a5746ec-1709-46f9-be21-ca259a143f89", "7a5746ec-1709-46f9-be21-ca259a143f89" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a5746ec-1709-46f9-be21-ca259a143f89");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "teams",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 25, 41, 614, DateTimeKind.Local).AddTicks(6773),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 21, 33, 151, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "players",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 25, 41, 614, DateTimeKind.Local).AddTicks(5451),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 21, 33, 151, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a5746ec-1709-46f9-be21-ca259a143f89",
                column: "ConcurrencyStamp",
                value: "5136ee7f-7e1d-444a-b805-57f5b85d26a4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c6c3033-a1b8-4cfe-929e-3c31928b4607", "259ba215-d3ad-47cf-8d94-98853cadfe8a", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c6c3033-a1b8-4cfe-929e-3c31928b4607");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "teams",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 21, 33, 151, DateTimeKind.Local).AddTicks(9426),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 25, 41, 614, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "players",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 21, 33, 151, DateTimeKind.Local).AddTicks(8164),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 25, 41, 614, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a5746ec-1709-46f9-be21-ca259a143f89",
                column: "ConcurrencyStamp",
                value: "8c604d64-ad84-4c51-a08f-bd95cb40793a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "23065ef5-ffee-4695-9989-6f4dce43dacb", "d17f2373-dc87-479d-bca1-05dfe29720cf", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7a5746ec-1709-46f9-be21-ca259a143f89", 0, "7dd5511e-bf30-4e89-b341-5e59af7dc20f", "mohammed30981710@f-eng.tanta.edu.eg", false, "Muhammad Badea", false, null, "MOHAMMED30981710@F-ENG.TANTA.EDU.EG", "BADEA", null, null, false, "989f6799-430c-4d12-ae8f-c7795fe96c66", false, "Badea" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7a5746ec-1709-46f9-be21-ca259a143f89", "7a5746ec-1709-46f9-be21-ca259a143f89" });
        }
    }
}
