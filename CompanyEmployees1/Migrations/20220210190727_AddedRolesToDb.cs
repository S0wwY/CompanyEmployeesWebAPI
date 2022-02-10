using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyEmployees1.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c6055394-4fc9-42b8-a695-49385fc09598", "403e240e-d8ff-4ed2-89b6-391f1bfe3087", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed533b1d-76ed-4ca8-b4ad-c8fcc81e2cc7", "ba008a19-25a4-463a-99e5-10520efd3ac8", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6055394-4fc9-42b8-a695-49385fc09598");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed533b1d-76ed-4ca8-b4ad-c8fcc81e2cc7");
        }
    }
}
