using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OBookStore.Repository.Migrations
{
    public partial class mig_7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 13, 11, 1, 652, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 13, 11, 1, 654, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 13, 11, 1, 654, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 13, 11, 1, 654, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 13, 11, 1, 654, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 13, 11, 1, 654, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 13, 11, 1, 654, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 13, 11, 1, 654, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 13, 11, 1, 654, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 13, 11, 1, 654, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddressDescription", "CreatedDate", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, "Emek/Ankara/Turkey", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ksccmrtt@gmail.com", "Mert", "Kasaci", "aabb12", "5307802852", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PiskoKral" },
                    { 2, "Kecioren/Ankara/Turkey", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dmrsrkn@gmail.com", "Serkan", "Demir", "eqwe23", "5307801234", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FeristahKing" },
                    { 3, "Birlik/Ankara/Turkey", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "aktnbrkn@gmail.com", "Berkan", "Aktikan", "sqwe123", "5307804567", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OlumsuzKral" },
                    { 4, "Sisli/Istanbul/Turkey", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ksbckdlsd@gmail.com", "Dilsat", "Kisabacak", "qweq123", "5307801435", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BloombergTV" },
                    { 5, "Kayseri/Kayseri/Turkey", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "clkgzhn@gmail.com", "Oguzhan", "Celik", "qwee123", "5307801235", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RumKral" },
                    { 6, "Esenler/Istanbul/Turkey", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "trkmnhmt@gmail.com", "Ahmet", "Ertürkmen", "asda12312", "5307803242", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FullArtiFullPisko" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 12, 53, 14, 91, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 12, 53, 14, 91, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 12, 53, 14, 91, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 12, 53, 14, 91, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 12, 53, 14, 91, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 12, 53, 14, 91, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 12, 53, 14, 91, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 12, 53, 14, 91, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 12, 53, 14, 91, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 11, 12, 53, 14, 91, DateTimeKind.Local).AddTicks(9484));
        }
    }
}
