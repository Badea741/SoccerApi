using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soccer.Shared.Migrations
{
    public partial class AddedLocalizedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerTeam_Player_PlayersId",
                table: "PlayerTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerTeam_Team_TeamsId",
                table: "PlayerTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Player",
                table: "Player");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "284822b4-f95d-4286-bc53-928e3eddd825");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b52e88fd-0d2a-48ca-aaca-b0c5450f71e4");

            migrationBuilder.RenameTable(
                name: "Team",
                newName: "teams");

            migrationBuilder.RenameTable(
                name: "Player",
                newName: "players");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "teams",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 19, 8, 39, 350, DateTimeKind.Local).AddTicks(9802),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 5, 16, 15, 50, 420, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "teams",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "players",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 6, 19, 8, 39, 350, DateTimeKind.Local).AddTicks(8631),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 5, 16, 15, 50, 420, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.AddPrimaryKey(
                name: "PK_teams",
                table: "teams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_players",
                table: "players",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "695691fb-edba-4901-a04a-36eda57988c5", "b0664270-8ced-4bba-a912-8eac764a2bcb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77ea28bd-92f7-48fc-a0df-cb4207a4fdec", "c5e2bf81-a375-4a42-82fc-71611bd17acf", "Admin", "ADMIN" });

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerTeam_players_PlayersId",
                table: "PlayerTeam",
                column: "PlayersId",
                principalTable: "players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerTeam_teams_TeamsId",
                table: "PlayerTeam",
                column: "TeamsId",
                principalTable: "teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerTeam_players_PlayersId",
                table: "PlayerTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerTeam_teams_TeamsId",
                table: "PlayerTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teams",
                table: "teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_players",
                table: "players");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "695691fb-edba-4901-a04a-36eda57988c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77ea28bd-92f7-48fc-a0df-cb4207a4fdec");

            migrationBuilder.RenameTable(
                name: "teams",
                newName: "Team");

            migrationBuilder.RenameTable(
                name: "players",
                newName: "Player");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Team",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 16, 15, 50, 420, DateTimeKind.Local).AddTicks(5009),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 19, 8, 39, 350, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Team",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Player",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 16, 15, 50, 420, DateTimeKind.Local).AddTicks(3798),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 6, 19, 8, 39, 350, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Player",
                table: "Player",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "284822b4-f95d-4286-bc53-928e3eddd825", "674ec97d-7cdd-4c51-8ebc-8ea984972228", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b52e88fd-0d2a-48ca-aaca-b0c5450f71e4", "80a01151-09cc-4887-b950-80789d2437f8", "User", "USER" });

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerTeam_Player_PlayersId",
                table: "PlayerTeam",
                column: "PlayersId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerTeam_Team_TeamsId",
                table: "PlayerTeam",
                column: "TeamsId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
