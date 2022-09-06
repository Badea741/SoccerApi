using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soccer.Shared.Migrations
{
    public partial class seededAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52a007e9-321b-4f3d-a400-29fbc9ce0d5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d91b90cf-469d-48db-b233-b74ffacd8003");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "teams",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 11, 29, 507, DateTimeKind.Local).AddTicks(3574),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 0, 13, 224, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "players",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 11, 29, 507, DateTimeKind.Local).AddTicks(2436),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 0, 13, 224, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a5746ec-1709-46f9-be21-ca259a143f89", "b9c014a9-368e-4115-9b63-b889c1ce70f3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe4275c4-7733-4fab-b35c-bb82feb806c8", "e98ad6f0-c013-4f5b-b437-ed4d91da12fb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7a5746ec-1709-46f9-be21-ca259a143f89", 0, "630377c4-594d-42b8-a7e8-6b9c91d70264", "mohammed30981710@f-eng.tanta.edu.eg", false, "Muhammad Badea", false, null, null, null, null, null, false, "99a24132-5530-4d42-90f1-94ebb1eb400f", false, "Badea" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7a5746ec-1709-46f9-be21-ca259a143f89", "7a5746ec-1709-46f9-be21-ca259a143f89" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe4275c4-7733-4fab-b35c-bb82feb806c8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7a5746ec-1709-46f9-be21-ca259a143f89", "7a5746ec-1709-46f9-be21-ca259a143f89" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a5746ec-1709-46f9-be21-ca259a143f89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a5746ec-1709-46f9-be21-ca259a143f89");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "teams",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 0, 13, 224, DateTimeKind.Local).AddTicks(7832),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 11, 29, 507, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "players",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 0, 13, 224, DateTimeKind.Local).AddTicks(6556),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 11, 29, 507, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52a007e9-321b-4f3d-a400-29fbc9ce0d5e", "275d0605-2009-401e-adef-98363900b968", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d91b90cf-469d-48db-b233-b74ffacd8003", "534c9819-041d-427c-9f09-a15ba1e9e176", "User", "USER" });
        }
    }
}
