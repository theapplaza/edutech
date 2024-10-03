using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Edutech.Api.Migrations
{
    /// <inheritdoc />
    public partial class Addsecondcourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("2bbd601b-6212-423d-a90b-2bdcc5b4ec91"), new Guid("2d845e48-9621-4848-baf4-b7ca62a7dd27") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("2bbd601b-6212-423d-a90b-2bdcc5b4ec91"), new Guid("45a327a8-828c-4c41-97c8-963c04d5dd21") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("2bbd601b-6212-423d-a90b-2bdcc5b4ec91"), new Guid("74815533-fcf5-4654-80f3-96f3de826471") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("41f68679-b0ff-4c62-8ca8-b8edb5c818c1"), new Guid("2d845e48-9621-4848-baf4-b7ca62a7dd27") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("41f68679-b0ff-4c62-8ca8-b8edb5c818c1"), new Guid("45a327a8-828c-4c41-97c8-963c04d5dd21") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("30d73708-1e3d-4206-814b-eeb9d91bb02f"), new Guid("4802d84d-18a0-4a63-baac-8267b93ff215") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("30d73708-1e3d-4206-814b-eeb9d91bb02f"), new Guid("74815533-fcf5-4654-80f3-96f3de826471") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("20a6fb56-c942-4e2f-80a6-fe0cb8e25065"), new Guid("7a1f2361-dc73-432a-9842-c85cf91b88c4") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2bbd601b-6212-423d-a90b-2bdcc5b4ec91"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20a6fb56-c942-4e2f-80a6-fe0cb8e25065"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("30d73708-1e3d-4206-814b-eeb9d91bb02f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("41f68679-b0ff-4c62-8ca8-b8edb5c818c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d845e48-9621-4848-baf4-b7ca62a7dd27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45a327a8-828c-4c41-97c8-963c04d5dd21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4802d84d-18a0-4a63-baac-8267b93ff215"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74815533-fcf5-4654-80f3-96f3de826471"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a1f2361-dc73-432a-9842-c85cf91b88c4"));

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("9b2c5c2a-29cc-44b7-9994-cfe87102b399"), "This course is for students who want to learn how to grow a product", "Growth Product Management" },
                    { new Guid("a46ec693-469e-4af4-afa8-e9475c49d41b"), "This course is designed to introduce student to the world of product management", "Introduction to Product Management" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("d14819e3-c7c2-4fb9-a64e-a26fe3b74889"), null, "Admin", "ADMIN" },
                    { new Guid("efd40355-da50-4e3f-8b41-0eeedaaca90c"), null, "Student", "STUDENT" },
                    { new Guid("feee1d6d-9515-4dba-80ac-116bbfc6789a"), null, "Instructor", "INSTRUCTOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0901fdbc-e9d9-4fb7-b85d-a0c2e7bd5d15"), 0, "de824cc2-70ac-43a4-8d53-eb405d850c81", "instructor1@edutech.com", true, false, null, "INSTRUCTOR1@EDUTECH.COM", "INSTRUCTOR1", "AQAAAAIAAYagAAAAEBrm2y2DWT1LdCr/ISFTscY2viGFb7A0jIS9vU0cA1h7oc2aJHnCbkB5Lb6vmTQ/LA==", null, false, null, false, "instructor1" },
                    { new Guid("2f7861bd-3623-47a9-9733-cf0cb9c114d2"), 0, "4093768c-931b-48ad-9ab4-aa85b18ec80e", "student1@edutech.com", true, false, null, "STUDENT1@EDUTECH.COM", "STUDENT1", "AQAAAAIAAYagAAAAEL6lDcX9ferAYW6Fd3iOwGHEW5FPL3mnkK4CIcPCd4sayxU8aBRmmgrAEbItpBWZhg==", null, false, null, false, "student1" },
                    { new Guid("370f042e-9928-4faf-b88a-2c625281fcae"), 0, "1163f493-16b6-4825-928c-3dfb742f4f24", "instructor2@edutech.com", true, false, null, "INSTRUCTOR2@EDUTECH.COM", "INSTRUCTOR2", "AQAAAAIAAYagAAAAEAXRfBrZ+KbmscT47J+wSLHR59DZZBMZjkA7kbgNtsVexin9h7sM82L5efL3FJUlCQ==", null, false, null, false, "instructor2" },
                    { new Guid("f21bbc1e-afc5-4da3-b07c-f6b939af1bb1"), 0, "89565d20-9746-47a2-a4f9-42dd1a92bf49", "student2@edutech.com", true, false, null, "STUDENT2@EDUTECH.COM", "STUDENT2", "AQAAAAIAAYagAAAAEM1OSs72SB1Sib2XT1MK4F2NtlWTe47/XKfJv2ic4dq5BjpN+REnzc59SqAcSx4Rmg==", null, false, null, false, "student2" },
                    { new Guid("fec6071a-a541-46ff-98d7-bef4d532276d"), 0, "0081327a-cae7-47c6-b69a-3ea75112c91d", "admin@edutech.com", true, false, null, "ADMIN@EDUTECH.COM", "ADMIN", "AQAAAAIAAYagAAAAEI/uiXey9G8R+S7nnMamtHGkCralkvsNLRoRPOmdicmqlys2/9m8jmYDoPKIEcwrcw==", null, false, null, false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "UserCourses",
                columns: new[] { "CourseId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9b2c5c2a-29cc-44b7-9994-cfe87102b399"), new Guid("2f7861bd-3623-47a9-9733-cf0cb9c114d2") },
                    { new Guid("9b2c5c2a-29cc-44b7-9994-cfe87102b399"), new Guid("370f042e-9928-4faf-b88a-2c625281fcae") },
                    { new Guid("a46ec693-469e-4af4-afa8-e9475c49d41b"), new Guid("0901fdbc-e9d9-4fb7-b85d-a0c2e7bd5d15") },
                    { new Guid("a46ec693-469e-4af4-afa8-e9475c49d41b"), new Guid("2f7861bd-3623-47a9-9733-cf0cb9c114d2") },
                    { new Guid("a46ec693-469e-4af4-afa8-e9475c49d41b"), new Guid("f21bbc1e-afc5-4da3-b07c-f6b939af1bb1") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("feee1d6d-9515-4dba-80ac-116bbfc6789a"), new Guid("0901fdbc-e9d9-4fb7-b85d-a0c2e7bd5d15") },
                    { new Guid("efd40355-da50-4e3f-8b41-0eeedaaca90c"), new Guid("2f7861bd-3623-47a9-9733-cf0cb9c114d2") },
                    { new Guid("feee1d6d-9515-4dba-80ac-116bbfc6789a"), new Guid("370f042e-9928-4faf-b88a-2c625281fcae") },
                    { new Guid("efd40355-da50-4e3f-8b41-0eeedaaca90c"), new Guid("f21bbc1e-afc5-4da3-b07c-f6b939af1bb1") },
                    { new Guid("d14819e3-c7c2-4fb9-a64e-a26fe3b74889"), new Guid("fec6071a-a541-46ff-98d7-bef4d532276d") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("9b2c5c2a-29cc-44b7-9994-cfe87102b399"), new Guid("2f7861bd-3623-47a9-9733-cf0cb9c114d2") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("9b2c5c2a-29cc-44b7-9994-cfe87102b399"), new Guid("370f042e-9928-4faf-b88a-2c625281fcae") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("a46ec693-469e-4af4-afa8-e9475c49d41b"), new Guid("0901fdbc-e9d9-4fb7-b85d-a0c2e7bd5d15") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("a46ec693-469e-4af4-afa8-e9475c49d41b"), new Guid("2f7861bd-3623-47a9-9733-cf0cb9c114d2") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("a46ec693-469e-4af4-afa8-e9475c49d41b"), new Guid("f21bbc1e-afc5-4da3-b07c-f6b939af1bb1") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("feee1d6d-9515-4dba-80ac-116bbfc6789a"), new Guid("0901fdbc-e9d9-4fb7-b85d-a0c2e7bd5d15") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("efd40355-da50-4e3f-8b41-0eeedaaca90c"), new Guid("2f7861bd-3623-47a9-9733-cf0cb9c114d2") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("feee1d6d-9515-4dba-80ac-116bbfc6789a"), new Guid("370f042e-9928-4faf-b88a-2c625281fcae") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("efd40355-da50-4e3f-8b41-0eeedaaca90c"), new Guid("f21bbc1e-afc5-4da3-b07c-f6b939af1bb1") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d14819e3-c7c2-4fb9-a64e-a26fe3b74889"), new Guid("fec6071a-a541-46ff-98d7-bef4d532276d") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9b2c5c2a-29cc-44b7-9994-cfe87102b399"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a46ec693-469e-4af4-afa8-e9475c49d41b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d14819e3-c7c2-4fb9-a64e-a26fe3b74889"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efd40355-da50-4e3f-8b41-0eeedaaca90c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("feee1d6d-9515-4dba-80ac-116bbfc6789a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0901fdbc-e9d9-4fb7-b85d-a0c2e7bd5d15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f7861bd-3623-47a9-9733-cf0cb9c114d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("370f042e-9928-4faf-b88a-2c625281fcae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f21bbc1e-afc5-4da3-b07c-f6b939af1bb1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fec6071a-a541-46ff-98d7-bef4d532276d"));

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("2bbd601b-6212-423d-a90b-2bdcc5b4ec91"), "This course is designed to introduce student to the world of product management", "Introduction to Product Management" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("20a6fb56-c942-4e2f-80a6-fe0cb8e25065"), null, "Admin", "ADMIN" },
                    { new Guid("30d73708-1e3d-4206-814b-eeb9d91bb02f"), null, "Instructor", "INSTRUCTOR" },
                    { new Guid("41f68679-b0ff-4c62-8ca8-b8edb5c818c1"), null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("2d845e48-9621-4848-baf4-b7ca62a7dd27"), 0, "17796aa9-89f4-490b-b4dd-cb1358033753", "student2@edutech.com", true, false, null, "STUDENT2@EDUTECH.COM", "STUDENT2", "AQAAAAIAAYagAAAAEL0RHEfZFSzAD6D5NhfAIKUXkoUKiQ1VT2n0iIgwrkGeI7N6fhdM9q/1ITXBBwnHLg==", null, false, null, false, "student2" },
                    { new Guid("45a327a8-828c-4c41-97c8-963c04d5dd21"), 0, "5062b1cb-8c55-4d76-9ef0-fa23acfcb5c5", "student1@edutech.com", true, false, null, "STUDENT1@EDUTECH.COM", "STUDENT1", "AQAAAAIAAYagAAAAEM9bUZHCK0gmHX3C9pw42//SaElCnT0vqgJvTZS83xvGWdqVnr3r7k5e0T2kemFNiQ==", null, false, null, false, "student1" },
                    { new Guid("4802d84d-18a0-4a63-baac-8267b93ff215"), 0, "4e317163-0992-4134-ad02-bca874e6f119", "instructor2@edutech.com", true, false, null, "INSTRUCTOR2@EDUTECH.COM", "INSTRUCTOR2", "AQAAAAIAAYagAAAAEC/Ok529P8Iuh+//s26YQ4f8LgVw8mKQPE+qaUSBhmbHXEMvLLgSce0WTVg8ACJH7Q==", null, false, null, false, "instructor2" },
                    { new Guid("74815533-fcf5-4654-80f3-96f3de826471"), 0, "e5c6501e-d0d7-4340-b127-9aa706b34929", "instructor1@edutech.com", true, false, null, "INSTRUCTOR1@EDUTECH.COM", "INSTRUCTOR1", "AQAAAAIAAYagAAAAENT22RBddC21O//3Dv0dTitVMxB+yR2qVt/pgQb95nDog4AwsCNXq5sb8b136FJbZQ==", null, false, null, false, "instructor1" },
                    { new Guid("7a1f2361-dc73-432a-9842-c85cf91b88c4"), 0, "76d8476e-7e31-4148-92d8-bdf162558178", "admin@edutech.com", true, false, null, "ADMIN@EDUTECH.COM", "ADMIN", "AQAAAAIAAYagAAAAELuySz9oTEzj+aN5GoSUGz17RUHl4L8NdZS2fginHsnoRRnxCaaqN93dPYY7vNcWsg==", null, false, null, false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "UserCourses",
                columns: new[] { "CourseId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2bbd601b-6212-423d-a90b-2bdcc5b4ec91"), new Guid("2d845e48-9621-4848-baf4-b7ca62a7dd27") },
                    { new Guid("2bbd601b-6212-423d-a90b-2bdcc5b4ec91"), new Guid("45a327a8-828c-4c41-97c8-963c04d5dd21") },
                    { new Guid("2bbd601b-6212-423d-a90b-2bdcc5b4ec91"), new Guid("74815533-fcf5-4654-80f3-96f3de826471") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("41f68679-b0ff-4c62-8ca8-b8edb5c818c1"), new Guid("2d845e48-9621-4848-baf4-b7ca62a7dd27") },
                    { new Guid("41f68679-b0ff-4c62-8ca8-b8edb5c818c1"), new Guid("45a327a8-828c-4c41-97c8-963c04d5dd21") },
                    { new Guid("30d73708-1e3d-4206-814b-eeb9d91bb02f"), new Guid("4802d84d-18a0-4a63-baac-8267b93ff215") },
                    { new Guid("30d73708-1e3d-4206-814b-eeb9d91bb02f"), new Guid("74815533-fcf5-4654-80f3-96f3de826471") },
                    { new Guid("20a6fb56-c942-4e2f-80a6-fe0cb8e25065"), new Guid("7a1f2361-dc73-432a-9842-c85cf91b88c4") }
                });
        }
    }
}
