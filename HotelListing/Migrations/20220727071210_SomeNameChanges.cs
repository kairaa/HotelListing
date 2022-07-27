using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.Migrations
{
    public partial class SomeNameChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9177b3d8-3341-4b3f-964f-794507b222cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c17c9151-93ca-4806-acf9-50e93aba97b1");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "9177b3d8-3341-4b3f-964f-794507b222cd", "51fbecb2-5734-406f-8aa2-c4c8d883e1c1", "Administrator", "ADMINISTRATOR" },
                    { "c17c9151-93ca-4806-acf9-50e93aba97b1", "ae910464-d862-4c98-8695-fa892364c9ed", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2022, 7, 27, 10, 3, 47, 262, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDate",
                value: new DateTime(2022, 7, 27, 10, 3, 47, 262, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2022, 7, 27, 10, 3, 47, 262, DateTimeKind.Local).AddTicks(3969));
        }
    }
}
