using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Edutech.Api.Migrations
{
    /// <inheritdoc />
    public partial class RenameContentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Content_ContentType_ContentTypeId",
                table: "Content");

            migrationBuilder.DropForeignKey(
                name: "FK_Content_Modules_ModuleId",
                table: "Content");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContentType",
                table: "ContentType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Content",
                table: "Content");

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("1acc1f47-2b83-4f66-9dbd-15436da626c4"), new Guid("8a83461b-b70b-45c7-b833-e799d0243ae9") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("1acc1f47-2b83-4f66-9dbd-15436da626c4"), new Guid("a3336c48-f7af-4e71-9d6f-5b2a60de67c1") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("3bd3420e-3185-4166-a27d-683243479e8b"), new Guid("08d99f85-40a0-4551-a646-397b9af00dd1") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("3bd3420e-3185-4166-a27d-683243479e8b"), new Guid("4f504e1e-1a49-46a5-b4ca-683817ff4028") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("3bd3420e-3185-4166-a27d-683243479e8b"), new Guid("8a83461b-b70b-45c7-b833-e799d0243ae9") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("4e192ad0-2de8-4ba8-a055-7e9caf070051"), new Guid("08d99f85-40a0-4551-a646-397b9af00dd1") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e6c6fda0-68d2-4bb2-b4a9-5fae44e2dcf9"), new Guid("243a28d6-eea5-4972-8a96-3b670c25b6be") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("001e71ff-06b2-4ddf-8291-274a3e526b59"), new Guid("4f504e1e-1a49-46a5-b4ca-683817ff4028") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("001e71ff-06b2-4ddf-8291-274a3e526b59"), new Guid("8a83461b-b70b-45c7-b833-e799d0243ae9") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("4e192ad0-2de8-4ba8-a055-7e9caf070051"), new Guid("a3336c48-f7af-4e71-9d6f-5b2a60de67c1") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1acc1f47-2b83-4f66-9dbd-15436da626c4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3bd3420e-3185-4166-a27d-683243479e8b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("001e71ff-06b2-4ddf-8291-274a3e526b59"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4e192ad0-2de8-4ba8-a055-7e9caf070051"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e6c6fda0-68d2-4bb2-b4a9-5fae44e2dcf9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08d99f85-40a0-4551-a646-397b9af00dd1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("243a28d6-eea5-4972-8a96-3b670c25b6be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f504e1e-1a49-46a5-b4ca-683817ff4028"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a83461b-b70b-45c7-b833-e799d0243ae9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3336c48-f7af-4e71-9d6f-5b2a60de67c1"));

            migrationBuilder.RenameTable(
                name: "ContentType",
                newName: "ContentTypes");

            migrationBuilder.RenameTable(
                name: "Content",
                newName: "Contents");

            migrationBuilder.RenameIndex(
                name: "IX_Content_ModuleId",
                table: "Contents",
                newName: "IX_Contents_ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_Content_ContentTypeId",
                table: "Contents",
                newName: "IX_Contents_ContentTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContentTypes",
                table: "ContentTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contents",
                table: "Contents",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0b66304f-51cb-40c4-b632-684c19465f83"), "This course is for students who want to learn how to grow a product", "Growth Product Management" },
                    { new Guid("57e377f5-d089-47a5-a21e-91e4863bbf45"), "This course is designed to introduce student to the world of product management", "Introduction to Product Management" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("5c55e9ae-ee39-41fa-b292-c70c33fffa80"), null, "Instructor", "INSTRUCTOR" },
                    { new Guid("969c3cad-33a9-449e-8442-ea207ba2b921"), null, "Student", "STUDENT" },
                    { new Guid("db9d18d6-2cae-441d-bd4c-84a609964066"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("33125c2d-ca81-4e38-b620-52fa47fa6ea1"), 0, "d00b0fb4-a83e-49fa-9c7a-1057eb08f854", "instructor2@edutech.com", true, false, null, "INSTRUCTOR2@EDUTECH.COM", "INSTRUCTOR2", "AQAAAAIAAYagAAAAEBPU7GDkzdBLJK/fXRH79n+JXcE7dL55iVtTajLEDZhQokMgjmSMv/DlPAW6b5Tl/w==", null, false, null, false, "instructor2" },
                    { new Guid("ad6f8197-efe2-46e2-aa54-e6431f8b6086"), 0, "5c561597-1d74-402b-a717-6840cd6d6c27", "student1@edutech.com", true, false, null, "STUDENT1@EDUTECH.COM", "STUDENT1", "AQAAAAIAAYagAAAAEELl2sPuXEC0sRKdQ045aA0NrMxDVSvGzA90TRCVZnXxNPeTMXHo50rujJcZb4JHQA==", null, false, null, false, "student1" },
                    { new Guid("c25e9ca6-b5a8-4dd0-a951-a2075814e178"), 0, "950cb3c3-7339-41c9-93ae-80a91cfcaf35", "instructor1@edutech.com", true, false, null, "INSTRUCTOR1@EDUTECH.COM", "INSTRUCTOR1", "AQAAAAIAAYagAAAAEM9OuZ0b1KlC4I40rXRSSrytRMzNX05FBB3UCu5SczwYzAoh5n1JXnDcjPXXPKS4gQ==", null, false, null, false, "instructor1" },
                    { new Guid("d2029219-7378-448a-a01d-09acfeeb667a"), 0, "3da8fc0b-916b-4668-bc07-341f5942a7fa", "student2@edutech.com", true, false, null, "STUDENT2@EDUTECH.COM", "STUDENT2", "AQAAAAIAAYagAAAAEHLyarE9qvmMc6Q9LH+ysxFWQw09VtdNj7QRrc4NJw6DMNSrByiqcwxbzymMmPI74A==", null, false, null, false, "student2" },
                    { new Guid("fd13c7c5-7e11-47bc-ae23-290604abd005"), 0, "2f524e22-9aa4-4c82-a6ed-384f3c06dfd9", "admin@edutech.com", true, false, null, "ADMIN@EDUTECH.COM", "ADMIN", "AQAAAAIAAYagAAAAEB0BrQUDt82msPVxy/zkPImc724UEs5z3iZROgi0uLLRSV7B+XRo6j8oeLEoR6KUZw==", null, false, null, false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "UserCourses",
                columns: new[] { "CourseId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0b66304f-51cb-40c4-b632-684c19465f83"), new Guid("33125c2d-ca81-4e38-b620-52fa47fa6ea1") },
                    { new Guid("0b66304f-51cb-40c4-b632-684c19465f83"), new Guid("ad6f8197-efe2-46e2-aa54-e6431f8b6086") },
                    { new Guid("57e377f5-d089-47a5-a21e-91e4863bbf45"), new Guid("ad6f8197-efe2-46e2-aa54-e6431f8b6086") },
                    { new Guid("57e377f5-d089-47a5-a21e-91e4863bbf45"), new Guid("c25e9ca6-b5a8-4dd0-a951-a2075814e178") },
                    { new Guid("57e377f5-d089-47a5-a21e-91e4863bbf45"), new Guid("d2029219-7378-448a-a01d-09acfeeb667a") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("5c55e9ae-ee39-41fa-b292-c70c33fffa80"), new Guid("33125c2d-ca81-4e38-b620-52fa47fa6ea1") },
                    { new Guid("969c3cad-33a9-449e-8442-ea207ba2b921"), new Guid("ad6f8197-efe2-46e2-aa54-e6431f8b6086") },
                    { new Guid("5c55e9ae-ee39-41fa-b292-c70c33fffa80"), new Guid("c25e9ca6-b5a8-4dd0-a951-a2075814e178") },
                    { new Guid("969c3cad-33a9-449e-8442-ea207ba2b921"), new Guid("d2029219-7378-448a-a01d-09acfeeb667a") },
                    { new Guid("db9d18d6-2cae-441d-bd4c-84a609964066"), new Guid("fd13c7c5-7e11-47bc-ae23-290604abd005") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_ContentTypes_ContentTypeId",
                table: "Contents",
                column: "ContentTypeId",
                principalTable: "ContentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Modules_ModuleId",
                table: "Contents",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_ContentTypes_ContentTypeId",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Modules_ModuleId",
                table: "Contents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContentTypes",
                table: "ContentTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contents",
                table: "Contents");

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("0b66304f-51cb-40c4-b632-684c19465f83"), new Guid("33125c2d-ca81-4e38-b620-52fa47fa6ea1") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("0b66304f-51cb-40c4-b632-684c19465f83"), new Guid("ad6f8197-efe2-46e2-aa54-e6431f8b6086") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("57e377f5-d089-47a5-a21e-91e4863bbf45"), new Guid("ad6f8197-efe2-46e2-aa54-e6431f8b6086") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("57e377f5-d089-47a5-a21e-91e4863bbf45"), new Guid("c25e9ca6-b5a8-4dd0-a951-a2075814e178") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("57e377f5-d089-47a5-a21e-91e4863bbf45"), new Guid("d2029219-7378-448a-a01d-09acfeeb667a") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5c55e9ae-ee39-41fa-b292-c70c33fffa80"), new Guid("33125c2d-ca81-4e38-b620-52fa47fa6ea1") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("969c3cad-33a9-449e-8442-ea207ba2b921"), new Guid("ad6f8197-efe2-46e2-aa54-e6431f8b6086") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5c55e9ae-ee39-41fa-b292-c70c33fffa80"), new Guid("c25e9ca6-b5a8-4dd0-a951-a2075814e178") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("969c3cad-33a9-449e-8442-ea207ba2b921"), new Guid("d2029219-7378-448a-a01d-09acfeeb667a") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("db9d18d6-2cae-441d-bd4c-84a609964066"), new Guid("fd13c7c5-7e11-47bc-ae23-290604abd005") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0b66304f-51cb-40c4-b632-684c19465f83"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("57e377f5-d089-47a5-a21e-91e4863bbf45"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5c55e9ae-ee39-41fa-b292-c70c33fffa80"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("969c3cad-33a9-449e-8442-ea207ba2b921"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("db9d18d6-2cae-441d-bd4c-84a609964066"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33125c2d-ca81-4e38-b620-52fa47fa6ea1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad6f8197-efe2-46e2-aa54-e6431f8b6086"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c25e9ca6-b5a8-4dd0-a951-a2075814e178"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2029219-7378-448a-a01d-09acfeeb667a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd13c7c5-7e11-47bc-ae23-290604abd005"));

            migrationBuilder.RenameTable(
                name: "ContentTypes",
                newName: "ContentType");

            migrationBuilder.RenameTable(
                name: "Contents",
                newName: "Content");

            migrationBuilder.RenameIndex(
                name: "IX_Contents_ModuleId",
                table: "Content",
                newName: "IX_Content_ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_Contents_ContentTypeId",
                table: "Content",
                newName: "IX_Content_ContentTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContentType",
                table: "ContentType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Content",
                table: "Content",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1acc1f47-2b83-4f66-9dbd-15436da626c4"), "This course is for students who want to learn how to grow a product", "Growth Product Management" },
                    { new Guid("3bd3420e-3185-4166-a27d-683243479e8b"), "This course is designed to introduce student to the world of product management", "Introduction to Product Management" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("001e71ff-06b2-4ddf-8291-274a3e526b59"), null, "Student", "STUDENT" },
                    { new Guid("4e192ad0-2de8-4ba8-a055-7e9caf070051"), null, "Instructor", "INSTRUCTOR" },
                    { new Guid("e6c6fda0-68d2-4bb2-b4a9-5fae44e2dcf9"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("08d99f85-40a0-4551-a646-397b9af00dd1"), 0, "aab8eaed-1ac3-4159-a272-acc74d114faf", "instructor1@edutech.com", true, false, null, "INSTRUCTOR1@EDUTECH.COM", "INSTRUCTOR1", "AQAAAAIAAYagAAAAEEE+oUSkFU88qj61FL5296w1g1m/6hHgXWPm/WYUxt/CluVqnUHa9k3d+Ob+LpsIwg==", null, false, null, false, "instructor1" },
                    { new Guid("243a28d6-eea5-4972-8a96-3b670c25b6be"), 0, "f759e9cb-7772-4118-a17b-8d62ed7ac67d", "admin@edutech.com", true, false, null, "ADMIN@EDUTECH.COM", "ADMIN", "AQAAAAIAAYagAAAAECxTa7uIt9jugPA4dBawvEIOadWCt68TJmNf27bDWAeYxmarZAqCYtHWU5xRsy0yhg==", null, false, null, false, "admin" },
                    { new Guid("4f504e1e-1a49-46a5-b4ca-683817ff4028"), 0, "3b7089b2-2024-4978-aa4d-8fd4fc42fcdd", "student2@edutech.com", true, false, null, "STUDENT2@EDUTECH.COM", "STUDENT2", "AQAAAAIAAYagAAAAED2K9LlZrN1mBZn8ja0bJjFfSmRdp65sNPx1C8Rlc1DCZO5W8iAsAD4apqN5Fv4FsQ==", null, false, null, false, "student2" },
                    { new Guid("8a83461b-b70b-45c7-b833-e799d0243ae9"), 0, "7d216224-e392-440f-a4dd-cccb04da8f07", "student1@edutech.com", true, false, null, "STUDENT1@EDUTECH.COM", "STUDENT1", "AQAAAAIAAYagAAAAEP9iBZPxzoULwKJaihWeuH1amPB1q1ZxayMVGr4y7m8p0hAYxqjWHEHeMcpmPEXbkg==", null, false, null, false, "student1" },
                    { new Guid("a3336c48-f7af-4e71-9d6f-5b2a60de67c1"), 0, "98359dd0-522d-4eca-a2d2-6f6cb5ba65c3", "instructor2@edutech.com", true, false, null, "INSTRUCTOR2@EDUTECH.COM", "INSTRUCTOR2", "AQAAAAIAAYagAAAAEGMab+GsttyFUWqWxLKjSw6xBVo4FR2KdXoo1uEgQRQ5jYa2qgsfqdQZV/LwDS9d0A==", null, false, null, false, "instructor2" }
                });

            migrationBuilder.InsertData(
                table: "UserCourses",
                columns: new[] { "CourseId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1acc1f47-2b83-4f66-9dbd-15436da626c4"), new Guid("8a83461b-b70b-45c7-b833-e799d0243ae9") },
                    { new Guid("1acc1f47-2b83-4f66-9dbd-15436da626c4"), new Guid("a3336c48-f7af-4e71-9d6f-5b2a60de67c1") },
                    { new Guid("3bd3420e-3185-4166-a27d-683243479e8b"), new Guid("08d99f85-40a0-4551-a646-397b9af00dd1") },
                    { new Guid("3bd3420e-3185-4166-a27d-683243479e8b"), new Guid("4f504e1e-1a49-46a5-b4ca-683817ff4028") },
                    { new Guid("3bd3420e-3185-4166-a27d-683243479e8b"), new Guid("8a83461b-b70b-45c7-b833-e799d0243ae9") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4e192ad0-2de8-4ba8-a055-7e9caf070051"), new Guid("08d99f85-40a0-4551-a646-397b9af00dd1") },
                    { new Guid("e6c6fda0-68d2-4bb2-b4a9-5fae44e2dcf9"), new Guid("243a28d6-eea5-4972-8a96-3b670c25b6be") },
                    { new Guid("001e71ff-06b2-4ddf-8291-274a3e526b59"), new Guid("4f504e1e-1a49-46a5-b4ca-683817ff4028") },
                    { new Guid("001e71ff-06b2-4ddf-8291-274a3e526b59"), new Guid("8a83461b-b70b-45c7-b833-e799d0243ae9") },
                    { new Guid("4e192ad0-2de8-4ba8-a055-7e9caf070051"), new Guid("a3336c48-f7af-4e71-9d6f-5b2a60de67c1") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Content_ContentType_ContentTypeId",
                table: "Content",
                column: "ContentTypeId",
                principalTable: "ContentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Content_Modules_ModuleId",
                table: "Content",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
