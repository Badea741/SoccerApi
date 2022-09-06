using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soccer.Shared.Migrations
{
    public partial class removedLocalizationInDatabaseBadIdea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "695691fb-edba-4901-a04a-36eda57988c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77ea28bd-92f7-48fc-a0df-cb4207a4fdec");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "teams",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 0, 13, 224, DateTimeKind.Local).AddTicks(7832),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 19, 8, 39, 350, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "players",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 20, 0, 13, 224, DateTimeKind.Local).AddTicks(6556),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 19, 8, 39, 350, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52a007e9-321b-4f3d-a400-29fbc9ce0d5e", "275d0605-2009-401e-adef-98363900b968", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d91b90cf-469d-48db-b233-b74ffacd8003", "534c9819-041d-427c-9f09-a15ba1e9e176", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2022, 9, 6, 19, 8, 39, 350, DateTimeKind.Local).AddTicks(9802),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 0, 13, 224, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "players",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 19, 8, 39, 350, DateTimeKind.Local).AddTicks(8631),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 20, 0, 13, 224, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "695691fb-edba-4901-a04a-36eda57988c5", "b0664270-8ced-4bba-a912-8eac764a2bcb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77ea28bd-92f7-48fc-a0df-cb4207a4fdec", "c5e2bf81-a375-4a42-82fc-71611bd17acf", "Admin", "ADMIN" });
        }
    }
}
