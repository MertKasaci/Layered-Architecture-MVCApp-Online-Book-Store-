using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OBookStore.Repository.Migrations
{
    public partial class mig_last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 39, 37, 925, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 39, 37, 926, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 39, 37, 926, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 39, 37, 926, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 39, 37, 926, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 39, 37, 926, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 39, 37, 926, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 39, 37, 926, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 39, 37, 926, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 39, 37, 926, DateTimeKind.Local).AddTicks(7198));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 29, 30, 696, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 29, 30, 697, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 29, 30, 697, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 29, 30, 697, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 29, 30, 697, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 29, 30, 697, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 29, 30, 697, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 29, 30, 697, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 29, 30, 697, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 10, 23, 29, 30, 697, DateTimeKind.Local).AddTicks(7348));
        }
    }
}
