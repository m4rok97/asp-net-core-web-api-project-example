using Microsoft.EntityFrameworkCore.Migrations;

namespace CmpanyEmployees.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "27d9af89-2390-4d9d-b3b0-438c13f16250", "09962c32-77a2-4251-9c7e-b99733cda35e", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "96ef290f-3a46-4a54-b154-a5fe5a12da17", "8c81f32c-7a9a-495a-9785-3429f619d346", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27d9af89-2390-4d9d-b3b0-438c13f16250");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ef290f-3a46-4a54-b154-a5fe5a12da17");
        }
    }
}
