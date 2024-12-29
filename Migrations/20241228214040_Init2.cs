using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MachineParkManagement.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Machine",
                columns: new[] { "Id", "LastData", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("42508173-0138-4e8c-b29f-006e477300a3"), "Temp: 68C", "Machine 2", "Offline" },
                    { new Guid("9ac3dd63-8b48-4118-8279-1b66b88a8c6c"), "Temp: 72C", "Machine 1", "Online" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Machine",
                keyColumn: "Id",
                keyValue: new Guid("42508173-0138-4e8c-b29f-006e477300a3"));

            migrationBuilder.DeleteData(
                table: "Machine",
                keyColumn: "Id",
                keyValue: new Guid("9ac3dd63-8b48-4118-8279-1b66b88a8c6c"));
        }
    }
}
