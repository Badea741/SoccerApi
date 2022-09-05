using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soccer.Shared.Migrations
{
    public partial class AddedSeededRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Team",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 16, 15, 50, 420, DateTimeKind.Local).AddTicks(5009),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 5, 16, 10, 17, 843, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Player",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 16, 15, 50, 420, DateTimeKind.Local).AddTicks(3798),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 5, 16, 10, 17, 843, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "284822b4-f95d-4286-bc53-928e3eddd825", "674ec97d-7cdd-4c51-8ebc-8ea984972228", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b52e88fd-0d2a-48ca-aaca-b0c5450f71e4", "80a01151-09cc-4887-b950-80789d2437f8", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "284822b4-f95d-4286-bc53-928e3eddd825");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b52e88fd-0d2a-48ca-aaca-b0c5450f71e4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Team",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 16, 10, 17, 843, DateTimeKind.Local).AddTicks(4104),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 5, 16, 15, 50, 420, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Player",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 16, 10, 17, 843, DateTimeKind.Local).AddTicks(2952),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 5, 16, 15, 50, 420, DateTimeKind.Local).AddTicks(3798));
        }
    }
}
