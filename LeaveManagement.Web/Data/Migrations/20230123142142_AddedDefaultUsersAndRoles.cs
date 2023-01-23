using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c2a5081-39f8-4a14-a950-4086b43f2fb6", "f213ad0e-bc5a-4234-ac4d-03266f51f7f9", "Administrator", "ADMINISTRATOR" },
                    { "9351206b-47e3-425d-9ba7-b3c544d88d59", "954bcc64-9315-4ef1-b10b-e4132f71d2df", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a1924f34-01ea-4e44-b006-21fe720c30b7", 0, "b057af08-62f3-45cc-8f5b-15124107c051", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEIXNL5OZbzyMo8foRVHL1jmbTJQRKHY6WOQLW1D8OeqUONkukwFNFZ9n/aqvKfSvhQ==", null, false, "b8369e8c-2d95-4a8e-b842-cf052546b9d4", null, false, null },
                    { "a8f8b6f5-1b91-449f-b946-c0c07417a2fa", 0, "e53744ce-a442-4d3b-8305-3059ec3bd69a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEPiK2ggtsdlGWudXABPn7oahbwcefcPX6xZ6eL5RveF2rS4Xs+FcRND6zlQXve1DrQ==", null, false, "a56ff4e3-f83e-4120-83bf-f1f278102331", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0c2a5081-39f8-4a14-a950-4086b43f2fb6", "a1924f34-01ea-4e44-b006-21fe720c30b7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9351206b-47e3-425d-9ba7-b3c544d88d59", "a8f8b6f5-1b91-449f-b946-c0c07417a2fa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0c2a5081-39f8-4a14-a950-4086b43f2fb6", "a1924f34-01ea-4e44-b006-21fe720c30b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9351206b-47e3-425d-9ba7-b3c544d88d59", "a8f8b6f5-1b91-449f-b946-c0c07417a2fa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c2a5081-39f8-4a14-a950-4086b43f2fb6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9351206b-47e3-425d-9ba7-b3c544d88d59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1924f34-01ea-4e44-b006-21fe720c30b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8f8b6f5-1b91-449f-b946-c0c07417a2fa");
        }
    }
}
