using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contact.Api.Migrations
{
    public partial class solvederrorfromtokenstring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "279e089a-a166-4790-a033-0b1636334714",
                column: "ConcurrencyStamp",
                value: "2554c729-40b7-42ad-90f5-129c8d2bd799");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abe24845-53a3-4a5c-9913-61f46aebc04b",
                column: "ConcurrencyStamp",
                value: "a1f0ab19-89c7-44ff-aef7-c1828df5f245");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83134663-7788-4b21-8ce7-afe80772a9d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deb4d5e3-4df3-4a15-998d-3fca88956e52", "AQAAAAEAACcQAAAAEFuhfTW2deD9dki+wb4RlDJc0tLz3UkJ//825+m82qF/s6i2L6cKD0wRVRM31WmOxg==", "30af7641-ed96-4e14-9eaa-56c2a1fe419c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc1ba891-6c2c-4718-a811-4e35d2e4d640",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa2c8838-7492-4cdd-9ca7-fecb4f856a02", "AQAAAAEAACcQAAAAENEYNdYPxxpYJn8kWdL9iGvuf/QRb+8rPHcZ7nyB6ssN9TmTEPP0AaQO50lNnKrGVg==", "6e6eeb9f-3ac0-454a-af5f-364ac3d88011" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
