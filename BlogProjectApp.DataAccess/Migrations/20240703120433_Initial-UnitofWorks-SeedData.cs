using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProjectApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialUnitofWorksSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 3, 15, 4, 32, 652, DateTimeKind.Local).AddTicks(8759), "/images/7.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 3, 15, 4, 32, 652, DateTimeKind.Local).AddTicks(8761), "/images/6.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 3, 15, 4, 32, 652, DateTimeKind.Local).AddTicks(8779), "/images/5.jpg" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 15, 4, 32, 652, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 15, 4, 32, 652, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 15, 4, 32, 652, DateTimeKind.Local).AddTicks(8671));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 3, 11, 27, 53, 180, DateTimeKind.Local).AddTicks(4363), "/themes/images/7.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 3, 11, 27, 53, 180, DateTimeKind.Local).AddTicks(4371), "~/themes/images/6.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 3, 11, 27, 53, 180, DateTimeKind.Local).AddTicks(4373), "~/themes/images/2.jpg" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 11, 27, 53, 180, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 11, 27, 53, 180, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 3, 11, 27, 53, 180, DateTimeKind.Local).AddTicks(4143));
        }
    }
}
