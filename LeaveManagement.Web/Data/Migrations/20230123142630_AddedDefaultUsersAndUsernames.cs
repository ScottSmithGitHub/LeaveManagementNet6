using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c2a5081-39f8-4a14-a950-4086b43f2fb6",
                column: "ConcurrencyStamp",
                value: "5aa99bb3-29ac-4e2e-97cc-df9e136c4ffa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9351206b-47e3-425d-9ba7-b3c544d88d59",
                column: "ConcurrencyStamp",
                value: "a41789e9-0a2d-42cb-89ba-e79424496741");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1924f34-01ea-4e44-b006-21fe720c30b7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "275b1693-e6e2-463f-8285-c0ddbc0ecdc6", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEO+781CFjarHWNXTqoQ7h/jD5a5IjXyHpVTrxmYO9o70siVxKgun+YoFVe2zuUL34A==", "95ff3167-dfba-4a52-973c-2dcc4903037d", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8f8b6f5-1b91-449f-b946-c0c07417a2fa",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a765e2e1-e7ff-4be9-87d7-cf7a76e786c3", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEElUmFp4AZrlDDeF9aKY+6PS1efMgBTasbIjZ8KeKg/pK5ORMK+umm57Ds/pxYmg+Q==", "01770711-c0bf-45bf-ad8a-a6fcc7492d56", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c2a5081-39f8-4a14-a950-4086b43f2fb6",
                column: "ConcurrencyStamp",
                value: "f213ad0e-bc5a-4234-ac4d-03266f51f7f9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9351206b-47e3-425d-9ba7-b3c544d88d59",
                column: "ConcurrencyStamp",
                value: "954bcc64-9315-4ef1-b10b-e4132f71d2df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1924f34-01ea-4e44-b006-21fe720c30b7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b057af08-62f3-45cc-8f5b-15124107c051", false, null, "AQAAAAEAACcQAAAAEIXNL5OZbzyMo8foRVHL1jmbTJQRKHY6WOQLW1D8OeqUONkukwFNFZ9n/aqvKfSvhQ==", "b8369e8c-2d95-4a8e-b842-cf052546b9d4", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8f8b6f5-1b91-449f-b946-c0c07417a2fa",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e53744ce-a442-4d3b-8305-3059ec3bd69a", false, null, "AQAAAAEAACcQAAAAEPiK2ggtsdlGWudXABPn7oahbwcefcPX6xZ6eL5RveF2rS4Xs+FcRND6zlQXve1DrQ==", "a56ff4e3-f83e-4120-83bf-f1f278102331", null });
        }
    }
}
