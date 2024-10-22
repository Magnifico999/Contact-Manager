using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contact.Api.Migrations
{
    public partial class now : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "279e089a-a166-4790-a033-0b1636334714",
                column: "ConcurrencyStamp",
                value: "92a2b37a-795b-4284-a545-d2415384d551");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abe24845-53a3-4a5c-9913-61f46aebc04b",
                column: "ConcurrencyStamp",
                value: "c86c7e07-2864-4889-9508-aae9ef5a4510");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83134663-7788-4b21-8ce7-afe80772a9d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0def06d-9b58-48c6-973d-7a32633e47af", "AQAAAAEAACcQAAAAEJmXPvBxTBR3PAi+w525Bn4YTNVHyky5FqCYwoaH/HF/uieCP2yIRO6mf1TS/LKhTQ==", "c2cf2da5-94c3-4c65-8083-56c09f8e6fa2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc1ba891-6c2c-4718-a811-4e35d2e4d640",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0beb4f0f-f306-463a-a78c-9c6ba358f767", "AQAAAAEAACcQAAAAENdxLSy/SO8htf0NhJZglX/wgC7Qwq7XmwQbqJPk1Zlvcjj63HuysoF/OJvpA3Nnsw==", "1f38bef7-415b-4ba0-b3b3-f8848571c326" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
