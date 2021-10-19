using Microsoft.EntityFrameworkCore.Migrations;

namespace TambuMail.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PhanLoai",
                keyColumn: "Id",
                keyValue: 1,
                column: "status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PhanLoai",
                keyColumn: "Id",
                keyValue: 2,
                column: "status",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PhanLoai",
                keyColumn: "Id",
                keyValue: 1,
                column: "status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PhanLoai",
                keyColumn: "Id",
                keyValue: 2,
                column: "status",
                value: 1);
        }
    }
}
