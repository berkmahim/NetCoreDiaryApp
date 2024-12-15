using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedDiaryEntries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "First diary content", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Diary Entry" },
                    { 2, "Second diary content", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Diary Entry" },
                    { 3, "Third diary content", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Third Diary Entry" },
                    { 4, "Fourth diary content", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fourth Diary Entry" }
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

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
