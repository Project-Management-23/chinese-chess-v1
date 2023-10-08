using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Libs.Migrations
{
    /// <inheritdoc />
    public partial class Addne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72b3cbed-0ac7-4eb2-acda-ceb3963e3839");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc1d4bec-423a-40b8-9ab2-5d25c02f725f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6bd11481-dd1d-478b-b69a-e39ae6ae369b", "dab184bd-fe5a-4fc5-ad34-44c6af45fed1", "User", "USER" },
                    { "adde06a2-f715-4f70-b25a-6a7ac5e8655f", "caaf5396-9f87-44f8-9e67-7e0b11cb0b04", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bd11481-dd1d-478b-b69a-e39ae6ae369b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adde06a2-f715-4f70-b25a-6a7ac5e8655f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "72b3cbed-0ac7-4eb2-acda-ceb3963e3839", "87309a3c-f713-4891-9774-04274c974c07", "User", "USER" },
                    { "bc1d4bec-423a-40b8-9ab2-5d25c02f725f", "996590ce-03be-4ec2-911f-7716af5fbf6b", "Admin", "ADMIN" }
                });
        }
    }
}
