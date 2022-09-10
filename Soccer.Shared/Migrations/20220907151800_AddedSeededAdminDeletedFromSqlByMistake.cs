using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soccer.Shared.Migrations
{
    public partial class AddedSeededAdminDeletedFromSqlByMistake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "teams",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 7, 17, 17, 59, 884, DateTimeKind.Local).AddTicks(3223),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 7, 15, 47, 2, 457, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "players",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 7, 17, 17, 59, 884, DateTimeKind.Local).AddTicks(1407),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 7, 15, 47, 2, 457, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1eff24d7-208c-4fdc-85e2-decd064a98ce",
                column: "ConcurrencyStamp",
                value: "b7d1ecb5-7aa6-4490-a401-40be5575b003");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a5746ec-1709-46f9-be21-ca259a143f88",
                column: "ConcurrencyStamp",
                value: "403b1dcb-e94e-4b54-9177-68cdfa958ef7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19a3c4ad-4a95-4327-9cdc-9dd4f4478d6c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58702879-108e-486e-9aad-76adcec70776", "AQAAAAEAACcQAAAAEMJUnUPTp1IHkNTtsqSGyKnkKE8JyGyOQ/6Jf7sRFI8bbHWTpQZkJiMyb/Uq2UBhkA==", "97e16723-20b7-4f85-b603-b9b6da7525be" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "teams",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 7, 15, 47, 2, 457, DateTimeKind.Local).AddTicks(9111),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 7, 17, 17, 59, 884, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "players",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 7, 15, 47, 2, 457, DateTimeKind.Local).AddTicks(7786),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 7, 17, 17, 59, 884, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1eff24d7-208c-4fdc-85e2-decd064a98ce",
                column: "ConcurrencyStamp",
                value: "ef423955-9e67-4a4b-a3c3-b41f3322e643");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a5746ec-1709-46f9-be21-ca259a143f88",
                column: "ConcurrencyStamp",
                value: "3721758f-3c4c-4160-9e10-85c8d945559e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19a3c4ad-4a95-4327-9cdc-9dd4f4478d6c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aede512e-17d0-429c-b1fb-5973ae0da6aa", "AQAAAAEAACcQAAAAENpUpFpRffMGLlKxCCyt6I6bBtcVjlM2hw8Cu2+R6C0JkQqza4pMBnU2H2E4gaVSzQ==", "7ccd3106-fb84-4dd4-b2dd-425550a85ea1" });
        }
    }
}
