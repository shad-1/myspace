using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myspace.Migrations
{
    public partial class addcontactimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "PhoneNumber",
                table: "People",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ImageFile",
                table: "People",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "ContactEvents",
                keyColumn: "ContactEventId",
                keyValue: 1,
                column: "DateTimeOccurred",
                value: new DateTime(2022, 10, 14, 9, 47, 17, 897, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "NoteId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 15, 9, 47, 17, 897, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "ImageFile", "PhoneNumber" },
                values: new object[] { "test1.jpeg", 8773012998L });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "ImageFile", "PhoneNumber" },
                values: new object[] { "test2.jpeg", 8783022999L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFile",
                table: "People");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "People",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "ContactEvents",
                keyColumn: "ContactEventId",
                keyValue: 1,
                column: "DateTimeOccurred",
                value: new DateTime(2022, 10, 13, 15, 13, 40, 121, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "NoteId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 14, 15, 13, 40, 121, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1,
                column: "PhoneNumber",
                value: "8773012998");

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2,
                column: "PhoneNumber",
                value: "8783022999");
        }
    }
}
