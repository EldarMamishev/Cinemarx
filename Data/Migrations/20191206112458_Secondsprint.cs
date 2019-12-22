using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Secondsprint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "PersonEntity",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "PersonEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "RegistrationDate" },
                values: new object[] { new DateTime(1999, 12, 6, 13, 24, 58, 80, DateTimeKind.Local).AddTicks(4063), new DateTime(2019, 12, 6, 13, 24, 58, 82, DateTimeKind.Local).AddTicks(526) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "PersonEntity");

            migrationBuilder.UpdateData(
                table: "PersonEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "RegistrationDate" },
                values: new object[] { new DateTime(1999, 11, 19, 22, 10, 58, 531, DateTimeKind.Local).AddTicks(1441), new DateTime(2019, 11, 19, 22, 10, 58, 532, DateTimeKind.Local).AddTicks(7651) });
        }
    }
}
