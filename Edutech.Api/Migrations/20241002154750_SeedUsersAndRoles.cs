using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Edutech.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("3570a732-4719-4b12-82c8-185d46cbcf3c"), null, "Student", "STUDENT" },
                    { new Guid("7db66dab-edbd-4e80-918b-bda6ae3367b4"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2e610b32-d18d-4213-84dc-e06579375d50"), 0, "37745013-561a-44ff-8024-468f91c3458f", "student2@edutech.com", true, false, null, "STUDENT2@EDUTECH.COM", "STUDENT2", "AQAAAAIAAYagAAAAEB6KgyB19MSS7dAsFonhWj5SZHt59PcvkYfEzOMUCMi1uhrWZHBBgS/bJIdIsZk1iQ==", null, false, null, false, "student2" },
                    { new Guid("bfe365b3-b0a5-4998-aa41-dfe0ac4d9da5"), 0, "7adda6bc-340a-49e0-9712-1984325822d8", "admin@edutech.com", true, false, null, "ADMIN@EDUTECH.COM", "ADMIN", "AQAAAAIAAYagAAAAEFOgfGLMKURKN0piK1wwdgfPYF5QvDbEDHXd9/r7chRdZ0XvP/YTd1dix5a0+zwTFg==", null, false, null, false, "admin" },
                    { new Guid("c847e98d-99c6-40da-8785-c25bf3532632"), 0, "23370e4b-ec99-440d-b2fd-add35032da6a", "student1@edutech.com", true, false, null, "STUDENT1@EDUTECH.COM", "STUDENT1", "AQAAAAIAAYagAAAAEN2mTgpiku4VLSEmhcMjkTrDoeBKADzd45Dc9+Ug1mykhoRBHo+Qj60dA4089XQGCQ==", null, false, null, false, "student1" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3570a732-4719-4b12-82c8-185d46cbcf3c"), new Guid("2e610b32-d18d-4213-84dc-e06579375d50") },
                    { new Guid("7db66dab-edbd-4e80-918b-bda6ae3367b4"), new Guid("bfe365b3-b0a5-4998-aa41-dfe0ac4d9da5") },
                    { new Guid("3570a732-4719-4b12-82c8-185d46cbcf3c"), new Guid("c847e98d-99c6-40da-8785-c25bf3532632") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3570a732-4719-4b12-82c8-185d46cbcf3c"), new Guid("2e610b32-d18d-4213-84dc-e06579375d50") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("7db66dab-edbd-4e80-918b-bda6ae3367b4"), new Guid("bfe365b3-b0a5-4998-aa41-dfe0ac4d9da5") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3570a732-4719-4b12-82c8-185d46cbcf3c"), new Guid("c847e98d-99c6-40da-8785-c25bf3532632") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3570a732-4719-4b12-82c8-185d46cbcf3c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7db66dab-edbd-4e80-918b-bda6ae3367b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2e610b32-d18d-4213-84dc-e06579375d50"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfe365b3-b0a5-4998-aa41-dfe0ac4d9da5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c847e98d-99c6-40da-8785-c25bf3532632"));
        }
    }
}
