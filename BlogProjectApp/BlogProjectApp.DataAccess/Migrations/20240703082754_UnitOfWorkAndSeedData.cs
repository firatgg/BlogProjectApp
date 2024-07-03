using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogProjectApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UnitOfWorkAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 3, 11, 27, 53, 180, DateTimeKind.Local).AddTicks(4122), "C# .Net Introduction", false, "C#.Net Core Programing" },
                    { 2, new DateTime(2024, 7, 3, 11, 27, 53, 180, DateTimeKind.Local).AddTicks(4141), "Entity Framework Core ile ORM Teknolojileri", false, "Entity Framework Core" },
                    { 3, new DateTime(2024, 7, 3, 11, 27, 53, 180, DateTimeKind.Local).AddTicks(4143), "Asp Net Cıre Mvc ile Web Programcılığı", false, "Asp Net Core MVC" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "IsDeleted", "PictureUrl", "Summary", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Visual Studio Net  ortamında C# Net Core ile temel seviyeden (veri türleri,değişkenler,if-else,dögüler,diziler) ileri seviyeye(nesneye daalı programlama -opp,collections,generic collections,interfaces,linq) eğitim programı)", new DateTime(2024, 7, 3, 11, 27, 53, 180, DateTimeKind.Local).AddTicks(4363), false, "/themes/images/7.jpg", "Visual Studio Net  ortamında C# Net Core ile temel seviyeden (veri türleri,değişkenler,if-else,dögüler,diziler)", "C# Net Core Introduction", 1 },
                    { 2, 2, "Visual studio.Net ortamında entity framework core ırn teknolojisini kullanarak veri tabanı varlılarının nesnel olarak yazılım tarafına atarılamsı ve yönetilmesi", new DateTime(2024, 7, 3, 11, 27, 53, 180, DateTimeKind.Local).AddTicks(4371), false, "~/themes/images/6.jpg", "Visual studio.Net ortamında entity framework core ırn teknolojisini kullanarak veri tabanı varlılarının nesnel olarak yazılım tarafına atarılamsı ve yönetilmesi...", "Entity Framework Core ile Orm", 2 },
                    { 3, 3, "visual studio net ortamında asp.net core mvc ile temel düzeyden ileri seviyeye web programlama eğitimi,asp.net Restfull  APIs...", new DateTime(2024, 7, 3, 11, 27, 53, 180, DateTimeKind.Local).AddTicks(4373), false, "~/themes/images/2.jpg", "visual studio net ortamında asp.net core mvc ile temel düzeyden ileri seviyeye web programlama eğitimi,asp.net Restfull  APIs", "Asp Net Core mvc web programlama", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
