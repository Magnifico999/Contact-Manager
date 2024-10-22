using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contact.Api.Migrations
{
    public partial class contactTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "279e089a-a166-4790-a033-0b1636334714",
                column: "ConcurrencyStamp",
                value: "e835c1ce-243d-4e26-8b24-ca2715390b6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abe24845-53a3-4a5c-9913-61f46aebc04b",
                column: "ConcurrencyStamp",
                value: "a14a8dc3-5680-49a8-9554-6ed19a0ad4cd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83134663-7788-4b21-8ce7-afe80772a9d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a69fde3a-32a3-42a4-88bb-38f0a52f9438", "AQAAAAEAACcQAAAAEGujr5BCpDXOcqOu5iz48BMxvVD2kKRRCNTufC91kC/M5NlNr7QwYu2TgBoOuD4Hgw==", "b457b2b3-844a-4bb1-a468-2b70fcf5c9cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc1ba891-6c2c-4718-a811-4e35d2e4d640",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2ad630c-3915-49bf-8ca8-d19d54d1dcf0", "AQAAAAEAACcQAAAAEGV6Y6iqdTv6HW1nL2DuquqSwhqsQwwKCHD2UjPPXBIDMAZhjcDGBpfue8tNCLum9A==", "6d963e80-549b-4c6c-b1e1-a79e6834e602" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "279e089a-a166-4790-a033-0b1636334714",
                column: "ConcurrencyStamp",
                value: "23cc525c-5ecb-4b58-b578-f77b650fe199");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abe24845-53a3-4a5c-9913-61f46aebc04b",
                column: "ConcurrencyStamp",
                value: "c4218b99-dda0-4d0b-9e95-a5808c278032");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83134663-7788-4b21-8ce7-afe80772a9d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72c250bf-ea06-47dc-a007-c0a1200f19b2", "AQAAAAEAACcQAAAAEMotpdtW65o/CjZSvjg7hk2BRKYhkRrxdTeI50zAeiijkf/qBpXR3wYrFQaw7YudPQ==", "7d9470bb-7928-4ba5-a7f0-4a33d086edbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc1ba891-6c2c-4718-a811-4e35d2e4d640",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e770a991-4f85-4a9e-b70c-e1cb6835851d", "AQAAAAEAACcQAAAAEOCiZd5Dq/mz1bg1ZsAzYgtb6zzjWeiLykkpUyL5mrLl0TbgpoYZn89kdeaSuJwbJg==", "5f76c716-7251-44b2-85e9-0a9ec96b43c3" });
        }
    }
}
