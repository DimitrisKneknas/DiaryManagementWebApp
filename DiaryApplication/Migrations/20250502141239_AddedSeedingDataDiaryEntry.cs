using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApplication.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with Joe!", new DateTime(2025, 5, 2, 17, 12, 38, 215, DateTimeKind.Local).AddTicks(8677), "Went Hiking" },
                    { 2, "Went shoping with Joe!", new DateTime(2025, 5, 2, 17, 12, 38, 215, DateTimeKind.Local).AddTicks(8683), "Went Shoping" },
                    { 3, "Went diving with Joe!", new DateTime(2025, 5, 2, 17, 12, 38, 215, DateTimeKind.Local).AddTicks(8687), "Went Diving" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
