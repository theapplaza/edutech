using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Edutech.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContentTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modules_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCourses",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCourses", x => new { x.CourseId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCourses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_ContentTypes_ContentTypeId",
                        column: x => x.ContentTypeId,
                        principalTable: "ContentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contents_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ContentTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5b65ae10-b29c-41b7-8ba5-4e2be130da84"), "Text" },
                    { new Guid("6a6a3696-28d8-4654-b42f-7abb11f3a2a5"), "Quiz" },
                    { new Guid("7cc0ccb8-0d6b-4d9a-a597-14c70b0b2de3"), "Video" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0e03d27a-f78a-4717-a029-f4c5bf653b97"), "This course is designed to introduce student to the world of product management", "Introduction to Product Management" },
                    { new Guid("1b30b805-ee65-4e04-b4bd-d0b44f279de1"), "This course is for students who want to learn how to grow a product", "Growth Product Management" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("b06fed02-c430-4e2b-81e0-7a316876bd40"), null, "Admin", "ADMIN" },
                    { new Guid("d2828b61-9d05-4dc6-b268-575cad5ffe26"), null, "Instructor", "INSTRUCTOR" },
                    { new Guid("fe1334b4-bfa3-4237-bdcc-252da5810409"), null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("03b94467-cca0-463c-9a3d-64188fc3fe35"), 0, "42716b7a-f754-4f7a-a49a-9cf00de40acd", "student2@edutech.com", true, false, null, "STUDENT2@EDUTECH.COM", "STUDENT2", "AQAAAAIAAYagAAAAEFNl837noIug9wfG+g6zEhnXuWYi2LIq/jDSFt+Owz9+f7ZWBYcMAWUPYMmG671C7g==", null, false, null, false, "student2" },
                    { new Guid("65a2df6c-214f-4e32-b629-54d1ce258cea"), 0, "14cf8aa7-a1b4-493f-8346-7289efbfcd2d", "admin@edutech.com", true, false, null, "ADMIN@EDUTECH.COM", "ADMIN", "AQAAAAIAAYagAAAAEBu4l9hpaxQbnXBP0mZHhQj2oXuMB6yQuZTun4eqs1KWSWOZvKLvZGMG5E1rZ8VPVQ==", null, false, null, false, "admin" },
                    { new Guid("9fec92ff-0485-4dea-a47f-e5b33d3dca98"), 0, "67e22f47-eb9c-403a-b5be-882daab11a31", "instructor1@edutech.com", true, false, null, "INSTRUCTOR1@EDUTECH.COM", "INSTRUCTOR1", "AQAAAAIAAYagAAAAEOE2YI3a4lsOZrb3TTC2ZLOa4eMDryK/kXOJOHsE979TN+FrXPnV22lfX0wtljIAOQ==", null, false, null, false, "instructor1" },
                    { new Guid("ccb2ad0e-5f9a-417a-bf38-df935e1a1528"), 0, "8cda219d-73a2-48d6-bc7b-e1ad27425ede", "student1@edutech.com", true, false, null, "STUDENT1@EDUTECH.COM", "STUDENT1", "AQAAAAIAAYagAAAAEJGmfBaizjzNWMDJ8LukCR3XLHYjUzT8kpDAPol4WZ8x9IM0rkWyNav1IMFiDcm7rg==", null, false, null, false, "student1" },
                    { new Guid("d5e632ac-fad1-4725-8cbf-50409fe241ba"), 0, "aff21424-1ba8-4841-abd4-e2868835f56a", "instructor2@edutech.com", true, false, null, "INSTRUCTOR2@EDUTECH.COM", "INSTRUCTOR2", "AQAAAAIAAYagAAAAEErR6lx3WrA5lX8N9sVj2X/rtvmi43fDhcnEtjtUkZv29ASEzoO1YlUr2/ZBzH4nqQ==", null, false, null, false, "instructor2" }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "CourseId", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1d1f4fca-d514-4931-98e7-e807d6601957"), new Guid("0e03d27a-f78a-4717-a029-f4c5bf653b97"), null, "Product Management Basic" },
                    { new Guid("69dd4e16-4687-48f5-99a5-5ce423204c11"), new Guid("0e03d27a-f78a-4717-a029-f4c5bf653b97"), null, "Product Management Framework" },
                    { new Guid("709ab670-b7c5-4702-b82b-57f31eaf093c"), new Guid("0e03d27a-f78a-4717-a029-f4c5bf653b97"), null, "Product Management Tools" },
                    { new Guid("e468724c-cb14-4420-b31a-ada65e45356d"), new Guid("1b30b805-ee65-4e04-b4bd-d0b44f279de1"), null, "Growth Product Management Framework" },
                    { new Guid("f9b4a3e0-5a85-4bfd-a970-cc78a94bef87"), new Guid("1b30b805-ee65-4e04-b4bd-d0b44f279de1"), null, "Introduction to Growth Product Management" }
                });

            migrationBuilder.InsertData(
                table: "UserCourses",
                columns: new[] { "CourseId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0e03d27a-f78a-4717-a029-f4c5bf653b97"), new Guid("03b94467-cca0-463c-9a3d-64188fc3fe35") },
                    { new Guid("0e03d27a-f78a-4717-a029-f4c5bf653b97"), new Guid("9fec92ff-0485-4dea-a47f-e5b33d3dca98") },
                    { new Guid("0e03d27a-f78a-4717-a029-f4c5bf653b97"), new Guid("ccb2ad0e-5f9a-417a-bf38-df935e1a1528") },
                    { new Guid("1b30b805-ee65-4e04-b4bd-d0b44f279de1"), new Guid("ccb2ad0e-5f9a-417a-bf38-df935e1a1528") },
                    { new Guid("1b30b805-ee65-4e04-b4bd-d0b44f279de1"), new Guid("d5e632ac-fad1-4725-8cbf-50409fe241ba") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("fe1334b4-bfa3-4237-bdcc-252da5810409"), new Guid("03b94467-cca0-463c-9a3d-64188fc3fe35") },
                    { new Guid("b06fed02-c430-4e2b-81e0-7a316876bd40"), new Guid("65a2df6c-214f-4e32-b629-54d1ce258cea") },
                    { new Guid("d2828b61-9d05-4dc6-b268-575cad5ffe26"), new Guid("9fec92ff-0485-4dea-a47f-e5b33d3dca98") },
                    { new Guid("fe1334b4-bfa3-4237-bdcc-252da5810409"), new Guid("ccb2ad0e-5f9a-417a-bf38-df935e1a1528") },
                    { new Guid("d2828b61-9d05-4dc6-b268-575cad5ffe26"), new Guid("d5e632ac-fad1-4725-8cbf-50409fe241ba") }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "ContentTypeId", "Description", "ModuleId", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("0a42db8d-4a9e-4d8b-a472-b41239680ce1"), new Guid("7cc0ccb8-0d6b-4d9a-a597-14c70b0b2de3"), null, new Guid("1d1f4fca-d514-4931-98e7-e807d6601957"), "Introduction to Product Management", "https://www.youtube.com/watch?v=9Qn0v6wJwPc" },
                    { new Guid("e5f803ea-1885-4efc-a3ff-da0cc8b327c0"), new Guid("5b65ae10-b29c-41b7-8ba5-4e2be130da84"), null, new Guid("1d1f4fca-d514-4931-98e7-e807d6601957"), "Career prospect for Product Managers", "https://www.productplan.com/glossary/product-management-framework/" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_ContentTypeId",
                table: "Contents",
                column: "ContentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_ModuleId",
                table: "Contents",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_CourseId",
                table: "Modules",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCourses_UserId",
                table: "UserCourses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserCourses");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "ContentTypes");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
