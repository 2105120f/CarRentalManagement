using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Vehicles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Models",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Makes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Colours",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Bookings",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 23, 13, 9, 9, 561, DateTimeKind.Local).AddTicks(5548), new DateTime(2022, 11, 23, 13, 9, 9, 563, DateTimeKind.Local).AddTicks(404), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 23, 13, 9, 9, 563, DateTimeKind.Local).AddTicks(2114), new DateTime(2022, 11, 23, 13, 9, 9, 563, DateTimeKind.Local).AddTicks(2122), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 23, 13, 9, 9, 565, DateTimeKind.Local).AddTicks(687), new DateTime(2022, 11, 23, 13, 9, 9, 565, DateTimeKind.Local).AddTicks(711), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 23, 13, 9, 9, 565, DateTimeKind.Local).AddTicks(719), new DateTime(2022, 11, 23, 13, 9, 9, 565, DateTimeKind.Local).AddTicks(721), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 23, 13, 9, 9, 565, DateTimeKind.Local).AddTicks(7762), new DateTime(2022, 11, 23, 13, 9, 9, 565, DateTimeKind.Local).AddTicks(7778), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 23, 13, 9, 9, 565, DateTimeKind.Local).AddTicks(7782), new DateTime(2022, 11, 23, 13, 9, 9, 565, DateTimeKind.Local).AddTicks(7783), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 23, 13, 9, 9, 565, DateTimeKind.Local).AddTicks(7785), new DateTime(2022, 11, 23, 13, 9, 9, 565, DateTimeKind.Local).AddTicks(7786), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 23, 13, 9, 9, 565, DateTimeKind.Local).AddTicks(7788), new DateTime(2022, 11, 23, 13, 9, 9, 565, DateTimeKind.Local).AddTicks(7789), "Rav4", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vehicles",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Models",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Makes",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Colours",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Bookings",
                newName: "ID");
        }
    }
}
