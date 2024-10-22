using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contact.Api.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "279e089a-a166-4790-a033-0b1636334714",
                column: "ConcurrencyStamp",
                value: "fcffa9ac-a86e-4118-a0d1-ca3c47a09d63");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abe24845-53a3-4a5c-9913-61f46aebc04b",
                column: "ConcurrencyStamp",
                value: "26265ee2-dba1-4bfe-bc0e-edbaedf1948c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83134663-7788-4b21-8ce7-afe80772a9d2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9a640ee-dada-4079-851c-f2c21d9f32cd", "AQAAAAEAACcQAAAAENWcTDtd1sa377GHgNK+aPOwhUazLF0CbsDyYu/6yJN99zQLF6NcNpDHcHoLyJfGjQ==", "cf989665-8359-4d8d-a835-f9db3afaf6a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc1ba891-6c2c-4718-a811-4e35d2e4d640",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a4ad906-bc77-4ab1-ad9a-bf3346e03f1a", "AQAAAAEAACcQAAAAEJFC3im8a9n/FZKuzn57NLyG4QOYD+JMdzPfveuAhJ+mQDDZ9kLSo1iqOQhROtHvrQ==", "98b90009-e0a1-45cd-a78d-029275106036" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
