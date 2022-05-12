using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FriendOrganizer.DataAccess.Migrations
{
    public partial class AddDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "thomasa@testfriendapp.com", "Thomas", "Anderson" },
                    { 2, "chuckn@testfriendapp.com", "Chuck", "Norris" },
                    { 3, "brucel@testfriendapp.com", "Bruce", "Lee" },
                    { 4, "jackiec@testfriendapp.com", "Jackie", "Chan" },
                    { 5, "jetl@testfriendapp.com", "Jet", "Li" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
