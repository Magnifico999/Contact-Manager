using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contact.Api.Migrations
{
    public partial class addrolesDefaultseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "279e089a-a166-4790-a033-0b1636334714", "23cc525c-5ecb-4b58-b578-f77b650fe199", "User", "USER" },
                    { "abe24845-53a3-4a5c-9913-61f46aebc04b", "c4218b99-dda0-4d0b-9e95-a5808c278032", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "83134663-7788-4b21-8ce7-afe80772a9d2", 0, "72c250bf-ea06-47dc-a007-c0a1200f19b2", "Admin@example.com", false, "Sodiq", "Alabi", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEMotpdtW65o/CjZSvjg7hk2BRKYhkRrxdTeI50zAeiijkf/qBpXR3wYrFQaw7YudPQ==", null, false, "image1.png", "7d9470bb-7928-4ba5-a7f0-4a33d086edbd", false, "Admin@example.com" },
                    { "cc1ba891-6c2c-4718-a811-4e35d2e4d640", 0, "e770a991-4f85-4a9e-b70c-e1cb6835851d", "user@example.com", false, "Ola", "Tboss", false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOCiZd5Dq/mz1bg1ZsAzYgtb6zzjWeiLykkpUyL5mrLl0TbgpoYZn89kdeaSuJwbJg==", null, false, "noimage.png", "5f76c716-7251-44b2-85e9-0a9ec96b43c3", false, "user@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "abe24845-53a3-4a5c-9913-61f46aebc04b", "83134663-7788-4b21-8ce7-afe80772a9d2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "279e089a-a166-4790-a033-0b1636334714", "cc1ba891-6c2c-4718-a811-4e35d2e4d640" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "abe24845-53a3-4a5c-9913-61f46aebc04b", "83134663-7788-4b21-8ce7-afe80772a9d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "279e089a-a166-4790-a033-0b1636334714", "cc1ba891-6c2c-4718-a811-4e35d2e4d640" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "279e089a-a166-4790-a033-0b1636334714");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abe24845-53a3-4a5c-9913-61f46aebc04b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83134663-7788-4b21-8ce7-afe80772a9d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc1ba891-6c2c-4718-a811-4e35d2e4d640");
        }
    }
}
