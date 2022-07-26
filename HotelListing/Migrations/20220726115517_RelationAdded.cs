using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.Migrations
{
    public partial class RelationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46e15d2d-b288-4fdc-8aca-5b92ad37f30d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54d21a18-d1d0-4930-8741-b317222e5ed2");

            migrationBuilder.AddColumn<string>(
                name: "ApiUserId",
                table: "Hotels",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27138bdd-3087-426c-9d9c-70f2923d740e", "9285c65c-0b2b-46d3-b2a8-a5936aad5108", "User", "USER" },
                    { "ce53489d-f145-4618-92f9-27ad813d5f5d", "6c8b075f-5a8a-4792-a992-ad9c46bada3d", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApiUserId",
                value: "ba073dce-0416-40d9-8a9c-e9372435c3f1");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "ApiUserId",
                value: "ba073dce-0416-40d9-8a9c-e9372435c3f1");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "ApiUserId",
                value: "e2e74b3c-d858-4934-b76e-3df438f5fcba");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_ApiUserId",
                table: "Hotels",
                column: "ApiUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_AspNetUsers_ApiUserId",
                table: "Hotels",
                column: "ApiUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_AspNetUsers_ApiUserId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_ApiUserId",
                table: "Hotels");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27138bdd-3087-426c-9d9c-70f2923d740e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce53489d-f145-4618-92f9-27ad813d5f5d");

            migrationBuilder.DropColumn(
                name: "ApiUserId",
                table: "Hotels");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46e15d2d-b288-4fdc-8aca-5b92ad37f30d", "49dcec38-dd14-4e10-9b16-ff3787b7b0fe", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "54d21a18-d1d0-4930-8741-b317222e5ed2", "bf877851-b739-4dd7-82ad-2b72a1599173", "Administrator", "ADMINISTRATOR" });
        }
    }
}
