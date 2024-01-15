using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagementTwo.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(8868), new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(8892), "Black", "System" },
                    { 2, "System", new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(8899), new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(8901), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(9447), new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(9450), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(9456), new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(9458), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(9844), new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(9847), "3 Series", "System" },
                    { 2, "System", new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(9852), new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(9855), "X5", "System" },
                    { 3, "System", new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(9859), new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(9862), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(9866), new DateTime(2024, 1, 15, 12, 32, 15, 740, DateTimeKind.Local).AddTicks(9869), "Rav4", "System" }
                });
        }

        /// <inheritdoc />
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
        }
    }
}
