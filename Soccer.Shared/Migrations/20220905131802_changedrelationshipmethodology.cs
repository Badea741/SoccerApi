using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Soccer.Shared.Migrations
{
    public partial class changedrelationshipmethodology : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerTeam_Player_PlayerId",
                table: "PlayerTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerTeam_Team_TeamId",
                table: "PlayerTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerTeam",
                table: "PlayerTeam");

            migrationBuilder.DropIndex(
                name: "IX_PlayerTeam_PlayerId",
                table: "PlayerTeam");

            migrationBuilder.DeleteData(
                table: "PlayerTeam",
                keyColumn: "Id",
                keyColumnType: "char(36)",
                keyValue: new Guid("ed1e3370-596e-4c54-98e2-0ee720a40d2c"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PlayerTeam");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "PlayerTeam");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "PlayerTeam");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "PlayerTeam",
                newName: "TeamsId");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "PlayerTeam",
                newName: "PlayersId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerTeam_TeamId",
                table: "PlayerTeam",
                newName: "IX_PlayerTeam_TeamsId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Founded",
                table: "Team",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Team",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 15, 18, 2, 149, DateTimeKind.Local).AddTicks(9603),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 4, 23, 19, 46, 941, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Player",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Player",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 5, 15, 18, 2, 149, DateTimeKind.Local).AddTicks(7681),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 4, 23, 19, 46, 941, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerTeam",
                table: "PlayerTeam",
                columns: new[] { "PlayersId", "TeamsId" });

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: new Guid("19a3c4ad-4a95-4327-9cdc-9dd4f4478d6c"),
                column: "DateOfBirth",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: new Guid("7cbad38c-3289-4857-a832-993ca4d672b7"),
                column: "DateOfBirth",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("0c3b24cd-cc84-4a1c-86f8-2810b0b3bfcc"),
                column: "Founded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("189f2330-0fcd-4e69-954f-5f690ea24b63"),
                column: "Founded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("1eff24d7-208c-4fdc-85e2-decd064a98cd"),
                column: "Founded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("26f3407d-f3f2-4b6a-8cae-73f12328967f"),
                column: "Founded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("6744ffd8-e113-4a25-bb84-89b9372e3b06"),
                column: "Founded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("7a5746ec-1709-46f9-be21-ca259a143f89"),
                column: "Founded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("ac2fe540-1126-4a64-abba-54fa7480da4c"),
                column: "Founded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("f9c228df-128e-4160-8f85-c6af9a188071"),
                column: "Founded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1878));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerTeam_Player_PlayersId",
                table: "PlayerTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerTeam_Team_TeamsId",
                table: "PlayerTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerTeam",
                table: "PlayerTeam");

            migrationBuilder.RenameColumn(
                name: "TeamsId",
                table: "PlayerTeam",
                newName: "TeamId");

            migrationBuilder.RenameColumn(
                name: "PlayersId",
                table: "PlayerTeam",
                newName: "PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerTeam_TeamsId",
                table: "PlayerTeam",
                newName: "IX_PlayerTeam_TeamId");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Founded",
                table: "Team",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Team",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 4, 23, 19, 46, 941, DateTimeKind.Local).AddTicks(6522),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 5, 15, 18, 2, 149, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PlayerTeam",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<DateTime>(
                name: "ConcurrencyStamp",
                table: "PlayerTeam",
                type: "timestamp(6)",
                rowVersion: true,
                nullable: false)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "PlayerTeam",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 4, 23, 19, 46, 941, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfBirth",
                table: "Player",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Player",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 4, 23, 19, 46, 941, DateTimeKind.Local).AddTicks(2970),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2022, 9, 5, 15, 18, 2, 149, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerTeam",
                table: "PlayerTeam",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: new Guid("19a3c4ad-4a95-4327-9cdc-9dd4f4478d6c"),
                column: "DateOfBirth",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: new Guid("7cbad38c-3289-4857-a832-993ca4d672b7"),
                column: "DateOfBirth",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.InsertData(
                table: "PlayerTeam",
                columns: new[] { "Id", "CreationDate", "PlayerId", "TeamId" },
                values: new object[] { new Guid("ed1e3370-596e-4c54-98e2-0ee720a40d2c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19a3c4ad-4a95-4327-9cdc-9dd4f4478d6c"), new Guid("7a5746ec-1709-46f9-be21-ca259a143f89") });

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("0c3b24cd-cc84-4a1c-86f8-2810b0b3bfcc"),
                column: "Founded",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("189f2330-0fcd-4e69-954f-5f690ea24b63"),
                column: "Founded",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("1eff24d7-208c-4fdc-85e2-decd064a98cd"),
                column: "Founded",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("26f3407d-f3f2-4b6a-8cae-73f12328967f"),
                column: "Founded",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("6744ffd8-e113-4a25-bb84-89b9372e3b06"),
                column: "Founded",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("7a5746ec-1709-46f9-be21-ca259a143f89"),
                column: "Founded",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("ac2fe540-1126-4a64-abba-54fa7480da4c"),
                column: "Founded",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("f9c228df-128e-4160-8f85-c6af9a188071"),
                column: "Founded",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.CreateIndex(
                name: "IX_PlayerTeam_PlayerId",
                table: "PlayerTeam",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerTeam_Player_PlayerId",
                table: "PlayerTeam",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerTeam_Team_TeamId",
                table: "PlayerTeam",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
