using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.Migrations
{
    public partial class PropertNamesChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27138bdd-3087-426c-9d9c-70f2923d740e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce53489d-f145-4618-92f9-27ad813d5f5d");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Context = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ApiUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_ApiUserId",
                        column: x => x.ApiUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9177b3d8-3341-4b3f-964f-794507b222cd", "51fbecb2-5734-406f-8aa2-c4c8d883e1c1", "Administrator", "ADMINISTRATOR" },
                    { "c17c9151-93ca-4806-acf9-50e93aba97b1", "ae910464-d862-4c98-8695-fa892364c9ed", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Test" },
                    { 2, "Comedy" },
                    { 3, "Problem" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApiUserId", "CategoryId", "Context", "PostDate", "Title" },
                values: new object[] { 1, "ba073dce-0416-40d9-8a9c-e9372435c3f1", 1, "This is first post in database", new DateTime(2022, 7, 27, 10, 3, 47, 262, DateTimeKind.Local).AddTicks(3936), "Title of first post" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApiUserId", "CategoryId", "Context", "PostDate", "Title" },
                values: new object[] { 2, "ba073dce-0416-40d9-8a9c-e9372435c3f1", 2, "This is second post of kairaa in database", new DateTime(2022, 7, 27, 10, 3, 47, 262, DateTimeKind.Local).AddTicks(3963), "Title of second post of kaira" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ApiUserId", "CategoryId", "Context", "PostDate", "Title" },
                values: new object[] { 3, "e2e74b3c-d858-4934-b76e-3df438f5fcba", 1, "This is first post of ulas in database", new DateTime(2022, 7, 27, 10, 3, 47, 262, DateTimeKind.Local).AddTicks(3969), "Title of first post of ulas" });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ApiUserId",
                table: "Posts",
                column: "ApiUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9177b3d8-3341-4b3f-964f-794507b222cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c17c9151-93ca-4806-acf9-50e93aba97b1");

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_AspNetUsers_ApiUserId",
                        column: x => x.ApiUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hotels_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27138bdd-3087-426c-9d9c-70f2923d740e", "9285c65c-0b2b-46d3-b2a8-a5936aad5108", "User", "USER" },
                    { "ce53489d-f145-4618-92f9-27ad813d5f5d", "6c8b075f-5a8a-4792-a992-ad9c46bada3d", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { 1, "Jamaica", "JM" },
                    { 2, "Bahamas", "BS" },
                    { 3, "Cayman Island", "CI" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "ApiUserId", "CountryId", "Name", "Rating" },
                values: new object[] { 1, "Negril", "ba073dce-0416-40d9-8a9c-e9372435c3f1", 1, "Sandals Resort and Spa", 4.5 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "ApiUserId", "CountryId", "Name", "Rating" },
                values: new object[] { 2, "George Town", "ba073dce-0416-40d9-8a9c-e9372435c3f1", 3, "Comfort Suites", 4.2999999999999998 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "ApiUserId", "CountryId", "Name", "Rating" },
                values: new object[] { 3, "Nassua", "e2e74b3c-d858-4934-b76e-3df438f5fcba", 2, "Grand Palldium", 4.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_ApiUserId",
                table: "Hotels",
                column: "ApiUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CountryId",
                table: "Hotels",
                column: "CountryId");
        }
    }
}
