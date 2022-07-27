using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.Migrations
{
    public partial class StringLengthRemovedFromBasePostDto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c009d2d1-d014-4906-ba6d-172f176ad53d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eca3f13e-7b43-49cf-a757-103f1ca26404");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0527b0cd-0787-4c48-a5cf-29190f06291c", "1df788c5-7b62-43eb-a3c2-956f0390f237", "Administrator", "ADMINISTRATOR" },
                    { "d8765021-d3f2-499b-b742-4f1d2833b37d", "477b1c27-d467-4d3d-a3ba-97cc27a71543", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2022, 7, 27, 10, 13, 11, 185, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDate",
                value: new DateTime(2022, 7, 27, 10, 13, 11, 185, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2022, 7, 27, 10, 13, 11, 185, DateTimeKind.Local).AddTicks(8905));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0527b0cd-0787-4c48-a5cf-29190f06291c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8765021-d3f2-499b-b742-4f1d2833b37d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c009d2d1-d014-4906-ba6d-172f176ad53d", "ce100bdd-2d73-45a2-a520-86e8986a6eaf", "User", "USER" },
                    { "eca3f13e-7b43-49cf-a757-103f1ca26404", "7384ee9b-08fd-4fa9-82a3-6d4f92c199a5", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2022, 7, 27, 10, 12, 9, 751, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDate",
                value: new DateTime(2022, 7, 27, 10, 12, 9, 751, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2022, 7, 27, 10, 12, 9, 751, DateTimeKind.Local).AddTicks(4303));
        }
    }
}
