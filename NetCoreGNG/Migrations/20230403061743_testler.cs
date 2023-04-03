using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreGNG.Migrations
{
    /// <inheritdoc />
    public partial class testler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 3, 9, 17, 43, 608, DateTimeKind.Local).AddTicks(346));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 3, 9, 10, 50, 839, DateTimeKind.Local).AddTicks(7350));
        }
    }
}
