using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TambuMail.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("b15e325e-9ff8-4e2a-91cb-3da62fb68fc6"), "4e865a39-d49f-4dae-945e-645bfe4e6dde", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("70551c02-fdf9-4d89-969d-4ae324f44a98"), new Guid("b15e325e-9ff8-4e2a-91cb-3da62fb68fc6") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CongTy", "Email", "EmailConfirmed", "Ho", "LockoutEnabled", "LockoutEnd", "NgaySinh", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Ten", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("70551c02-fdf9-4d89-969d-4ae324f44a98"), 0, "9d9841b4-3abb-43d2-886c-fbfe03171ae8", "HUFI", "anhhao987676476@gmail.com", true, "Dinh", false, null, new DateTime(2000, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "anhhao987676476@gmail.com", "admin", "AQAAAAEAACcQAAAAEAnnmA3pNfWhdJNrZTkdNXTmBBRIeza5kg8LhrBd/LLYxJl4sKETz3tyx9BlqX5zaQ==", null, false, "", "Hao", false, "admin" });

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
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("b15e325e-9ff8-4e2a-91cb-3da62fb68fc6"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("70551c02-fdf9-4d89-969d-4ae324f44a98"), new Guid("b15e325e-9ff8-4e2a-91cb-3da62fb68fc6") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("70551c02-fdf9-4d89-969d-4ae324f44a98"));

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
