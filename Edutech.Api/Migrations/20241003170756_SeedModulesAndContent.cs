using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Edutech.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedModulesAndContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ContentTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("21a95977-6322-4a79-90b6-96757a2b4274"), "Quiz" },
                    { new Guid("8eb520e2-5e2c-4e2a-a909-1e03176e89d5"), "Video" },
                    { new Guid("d1821405-7838-40f2-b87e-7f267f4e83ac"), "Text" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("23fddac3-9783-451a-afaf-57e07c354c59"), "This course is designed to introduce student to the world of product management", "Introduction to Product Management" },
                    { new Guid("a2761bb3-229b-40a2-90bf-d5f0ffa98475"), "This course is for students who want to learn how to grow a product", "Growth Product Management" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("527a1397-1c25-405d-bd4b-2e300534cb2d"), null, "Student", "STUDENT" },
                    { new Guid("85b521e1-23a0-482a-a110-f88f57fe6686"), null, "Instructor", "INSTRUCTOR" },
                    { new Guid("9db7de1a-39ff-4b58-b668-8104fa5dfaca"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("670a6a40-3166-423a-9bd6-4c001b5ac798"), 0, "f3d8c2af-a8e4-479a-b414-24c3d6b2cffb", "student1@edutech.com", true, false, null, "STUDENT1@EDUTECH.COM", "STUDENT1", "AQAAAAIAAYagAAAAEIzNGfs5uTnkkos/cwq8LTodPpbSy3tTSkeo8C2PbcdVrKb5bWDe8Ky8z/gNN7Uoiw==", null, false, null, false, "student1" },
                    { new Guid("6b83579a-6306-4580-a633-18173b1b51a3"), 0, "d692ca08-f1c7-4576-87d1-e374e52007fd", "admin@edutech.com", true, false, null, "ADMIN@EDUTECH.COM", "ADMIN", "AQAAAAIAAYagAAAAEIJ53y0MRZ6LGCgARrSk4eKYHu6O+h6P9KBSku19cdQwb5CVMGeGzq3OBCaSFfN9JQ==", null, false, null, false, "admin" },
                    { new Guid("9a694032-9a37-4dcb-879b-14289d035f9b"), 0, "e3eb7a5a-ebf3-4b42-96a4-985c0c17abf6", "instructor2@edutech.com", true, false, null, "INSTRUCTOR2@EDUTECH.COM", "INSTRUCTOR2", "AQAAAAIAAYagAAAAEODNqMfAAqNWvuzRXlJ1UdJex8eldJz79EnoCE+ZT83S0ZyzaqsIk/C+qFrytYgJWg==", null, false, null, false, "instructor2" },
                    { new Guid("bc3397a8-f51f-4139-a43d-60dd687096ce"), 0, "096fc7d8-e2c8-41fe-8be5-9a68e7b04b70", "instructor1@edutech.com", true, false, null, "INSTRUCTOR1@EDUTECH.COM", "INSTRUCTOR1", "AQAAAAIAAYagAAAAEJ5O/rneHNkDX5BzO/cIRWuZU/SSu11rfH1cokrwbxpVC+sMpQJmSH2BZZJrqwaFAg==", null, false, null, false, "instructor1" },
                    { new Guid("da7e7c22-f5dc-4e97-b02d-66ddb3669204"), 0, "bf0d8390-f839-4f8c-abc3-45512606f9b3", "student2@edutech.com", true, false, null, "STUDENT2@EDUTECH.COM", "STUDENT2", "AQAAAAIAAYagAAAAEHj20v4Pbz9W1AcJ+gT88Wckr/onNI51r0Ctzp0ksyVp+z9Lx/x1p4bNeyQfBpb8JA==", null, false, null, false, "student2" }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CourseId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("198d7878-c85b-4ea5-a6ca-ca5b8ec5380d"), new Guid("23fddac3-9783-451a-afaf-57e07c354c59"), null, "Product Management Basic" },
                    { new Guid("1ac4b288-f698-4820-92b9-66411da3de85"), new Guid("a2761bb3-229b-40a2-90bf-d5f0ffa98475"), null, "Introduction to Growth Product Management" },
                    { new Guid("80d07dc6-9d0f-4fd0-b442-98ff9ee32467"), new Guid("a2761bb3-229b-40a2-90bf-d5f0ffa98475"), null, "Growth Product Management Framework" },
                    { new Guid("c8a00e72-5e49-4455-98d6-1c02de96660f"), new Guid("23fddac3-9783-451a-afaf-57e07c354c59"), null, "Product Management Framework" },
                    { new Guid("f28b95b2-7c1f-4fac-a01f-7800f7bce073"), new Guid("23fddac3-9783-451a-afaf-57e07c354c59"), null, "Product Management Tools" }
                });

            migrationBuilder.InsertData(
                table: "UserCourses",
                columns: new[] { "CourseId", "UserId" },
                values: new object[,]
                {
                    { new Guid("23fddac3-9783-451a-afaf-57e07c354c59"), new Guid("670a6a40-3166-423a-9bd6-4c001b5ac798") },
                    { new Guid("23fddac3-9783-451a-afaf-57e07c354c59"), new Guid("bc3397a8-f51f-4139-a43d-60dd687096ce") },
                    { new Guid("23fddac3-9783-451a-afaf-57e07c354c59"), new Guid("da7e7c22-f5dc-4e97-b02d-66ddb3669204") },
                    { new Guid("a2761bb3-229b-40a2-90bf-d5f0ffa98475"), new Guid("670a6a40-3166-423a-9bd6-4c001b5ac798") },
                    { new Guid("a2761bb3-229b-40a2-90bf-d5f0ffa98475"), new Guid("9a694032-9a37-4dcb-879b-14289d035f9b") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("527a1397-1c25-405d-bd4b-2e300534cb2d"), new Guid("670a6a40-3166-423a-9bd6-4c001b5ac798") },
                    { new Guid("9db7de1a-39ff-4b58-b668-8104fa5dfaca"), new Guid("6b83579a-6306-4580-a633-18173b1b51a3") },
                    { new Guid("85b521e1-23a0-482a-a110-f88f57fe6686"), new Guid("9a694032-9a37-4dcb-879b-14289d035f9b") },
                    { new Guid("85b521e1-23a0-482a-a110-f88f57fe6686"), new Guid("bc3397a8-f51f-4139-a43d-60dd687096ce") },
                    { new Guid("527a1397-1c25-405d-bd4b-2e300534cb2d"), new Guid("da7e7c22-f5dc-4e97-b02d-66ddb3669204") }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "ContentTypeId", "Description", "ModuleId", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("7cd9e33c-496f-458b-8395-4b10eabd490a"), new Guid("d1821405-7838-40f2-b87e-7f267f4e83ac"), null, new Guid("198d7878-c85b-4ea5-a6ca-ca5b8ec5380d"), "Career prospect for Product Managers", "https://www.productplan.com/glossary/product-management-framework/" },
                    { new Guid("ae1aab82-824b-4c48-b005-dbf448dae7b7"), new Guid("8eb520e2-5e2c-4e2a-a909-1e03176e89d5"), null, new Guid("198d7878-c85b-4ea5-a6ca-ca5b8ec5380d"), "Introduction to Product Management", "https://www.youtube.com/watch?v=9Qn0v6wJwPc" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("21a95977-6322-4a79-90b6-96757a2b4274"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("7cd9e33c-496f-458b-8395-4b10eabd490a"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("ae1aab82-824b-4c48-b005-dbf448dae7b7"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("1ac4b288-f698-4820-92b9-66411da3de85"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("80d07dc6-9d0f-4fd0-b442-98ff9ee32467"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("c8a00e72-5e49-4455-98d6-1c02de96660f"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("f28b95b2-7c1f-4fac-a01f-7800f7bce073"));

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("23fddac3-9783-451a-afaf-57e07c354c59"), new Guid("670a6a40-3166-423a-9bd6-4c001b5ac798") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("23fddac3-9783-451a-afaf-57e07c354c59"), new Guid("bc3397a8-f51f-4139-a43d-60dd687096ce") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("23fddac3-9783-451a-afaf-57e07c354c59"), new Guid("da7e7c22-f5dc-4e97-b02d-66ddb3669204") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("a2761bb3-229b-40a2-90bf-d5f0ffa98475"), new Guid("670a6a40-3166-423a-9bd6-4c001b5ac798") });

            migrationBuilder.DeleteData(
                table: "UserCourses",
                keyColumns: new[] { "CourseId", "UserId" },
                keyValues: new object[] { new Guid("a2761bb3-229b-40a2-90bf-d5f0ffa98475"), new Guid("9a694032-9a37-4dcb-879b-14289d035f9b") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("527a1397-1c25-405d-bd4b-2e300534cb2d"), new Guid("670a6a40-3166-423a-9bd6-4c001b5ac798") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("9db7de1a-39ff-4b58-b668-8104fa5dfaca"), new Guid("6b83579a-6306-4580-a633-18173b1b51a3") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("85b521e1-23a0-482a-a110-f88f57fe6686"), new Guid("9a694032-9a37-4dcb-879b-14289d035f9b") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("85b521e1-23a0-482a-a110-f88f57fe6686"), new Guid("bc3397a8-f51f-4139-a43d-60dd687096ce") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("527a1397-1c25-405d-bd4b-2e300534cb2d"), new Guid("da7e7c22-f5dc-4e97-b02d-66ddb3669204") });

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("8eb520e2-5e2c-4e2a-a909-1e03176e89d5"));

            migrationBuilder.DeleteData(
                table: "ContentTypes",
                keyColumn: "Id",
                keyValue: new Guid("d1821405-7838-40f2-b87e-7f267f4e83ac"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a2761bb3-229b-40a2-90bf-d5f0ffa98475"));

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: new Guid("198d7878-c85b-4ea5-a6ca-ca5b8ec5380d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("527a1397-1c25-405d-bd4b-2e300534cb2d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("85b521e1-23a0-482a-a110-f88f57fe6686"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9db7de1a-39ff-4b58-b668-8104fa5dfaca"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("670a6a40-3166-423a-9bd6-4c001b5ac798"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b83579a-6306-4580-a633-18173b1b51a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a694032-9a37-4dcb-879b-14289d035f9b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc3397a8-f51f-4139-a43d-60dd687096ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da7e7c22-f5dc-4e97-b02d-66ddb3669204"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("23fddac3-9783-451a-afaf-57e07c354c59"));

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
        }
    }
}
