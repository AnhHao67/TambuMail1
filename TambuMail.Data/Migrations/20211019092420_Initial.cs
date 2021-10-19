using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TambuMail.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfig",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfig", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 15, nullable: false),
                    message = table.Column<string>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(maxLength: 200, nullable: false),
                    email = table.Column<string>(maxLength: 200, nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    SoDienThoai = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(maxLength: 200, nullable: true),
                    SoThich = table.Column<string>(maxLength: 1000, nullable: true),
                    ThongTin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NgonNgu",
                columns: table => new
                {
                    Id = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    IsDefault = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NgonNgu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhanLoai",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsShowOnHome = table.Column<bool>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    status = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanLoai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sending",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayGui = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sending", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailId = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    NgayTao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHang_Mail_MailId",
                        column: x => x.MailId,
                        principalTable: "Mail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChienDichInCategory",
                columns: table => new
                {
                    MailId = table.Column<int>(nullable: false),
                    PhanLoaiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChienDichInCategory", x => new { x.PhanLoaiId, x.MailId });
                    table.ForeignKey(
                        name: "FK_ChienDichInCategory_Mail_MailId",
                        column: x => x.MailId,
                        principalTable: "Mail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChienDichInCategory_PhanLoai_PhanLoaiId",
                        column: x => x.PhanLoaiId,
                        principalTable: "PhanLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhanLoaiTranslation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhanLoaiId = table.Column<int>(nullable: false),
                    Ten = table.Column<string>(maxLength: 200, nullable: false),
                    SeoDescription = table.Column<string>(maxLength: 500, nullable: true),
                    SeoTitle = table.Column<string>(maxLength: 200, nullable: true),
                    NgonNguId = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    SeoAlias = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanLoaiTranslation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhanLoaiTranslation_NgonNgu_NgonNguId",
                        column: x => x.NgonNguId,
                        principalTable: "NgonNgu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhanLoaiTranslation_PhanLoai_PhanLoaiId",
                        column: x => x.PhanLoaiId,
                        principalTable: "PhanLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SendingDetails",
                columns: table => new
                {
                    SendingId = table.Column<int>(nullable: false),
                    MailId = table.Column<int>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendingDetails", x => new { x.SendingId, x.MailId });
                    table.ForeignKey(
                        name: "FK_SendingDetails_Mail_MailId",
                        column: x => x.MailId,
                        principalTable: "Mail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SendingDetails_Sending_SendingId",
                        column: x => x.SendingId,
                        principalTable: "Sending",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppConfig",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is home page of TambuMail" },
                    { "HomeKeyword", "This is keyword of TambuMail" },
                    { "HomeDescription", "This is description of TambuMail" }
                });

            migrationBuilder.InsertData(
                table: "Mail",
                columns: new[] { "Id", "DiaChi", "HoTen", "NgaySinh", "SoDienThoai", "SoThich", "ThongTin", "email" },
                values: new object[] { 1, "9/9/11 đường số 9, phường Bình Hưng Hoà, quận Bình Tân, thành phố Hồ Chí Minh ", "Đinh Anh Hào", new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "0771212342", "Tiểu thuyết, game, đấu bài Yugioh", null, "dinhanhhao2033180037@gmail.com" });

            migrationBuilder.InsertData(
                table: "NgonNgu",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vi-VN", true, "Tiếng Việt" },
                    { "en-US", false, "English" }
                });

            migrationBuilder.InsertData(
                table: "PhanLoai",
                columns: new[] { "Id", "IsShowOnHome", "ParentId", "SortOrder", "status" },
                values: new object[,]
                {
                    { 1, true, null, 1, 1 },
                    { 2, true, null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "ChienDichInCategory",
                columns: new[] { "PhanLoaiId", "MailId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "PhanLoaiTranslation",
                columns: new[] { "Id", "NgonNguId", "PhanLoaiId", "SeoAlias", "SeoDescription", "SeoTitle", "Ten" },
                values: new object[] { 1, "vi-VN", 1, "sinh-nhat", "mail Chúc mừng sinh nhật", "mail Chúc mừng sinh nhật", "Chúc mừng sinh nhật" });

            migrationBuilder.InsertData(
                table: "PhanLoaiTranslation",
                columns: new[] { "Id", "NgonNguId", "PhanLoaiId", "SeoAlias", "SeoDescription", "SeoTitle", "Ten" },
                values: new object[] { 2, "en-US", 2, "happy-birthday", "Happy Birthday Mail", "Happy Birthday Mail", "Happy Birthday" });

            migrationBuilder.CreateIndex(
                name: "IX_ChienDichInCategory_MailId",
                table: "ChienDichInCategory",
                column: "MailId");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_MailId",
                table: "GioHang",
                column: "MailId");

            migrationBuilder.CreateIndex(
                name: "IX_PhanLoaiTranslation_NgonNguId",
                table: "PhanLoaiTranslation",
                column: "NgonNguId");

            migrationBuilder.CreateIndex(
                name: "IX_PhanLoaiTranslation_PhanLoaiId",
                table: "PhanLoaiTranslation",
                column: "PhanLoaiId");

            migrationBuilder.CreateIndex(
                name: "IX_SendingDetails_MailId",
                table: "SendingDetails",
                column: "MailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfig");

            migrationBuilder.DropTable(
                name: "ChienDichInCategory");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "PhanLoaiTranslation");

            migrationBuilder.DropTable(
                name: "SendingDetails");

            migrationBuilder.DropTable(
                name: "NgonNgu");

            migrationBuilder.DropTable(
                name: "PhanLoai");

            migrationBuilder.DropTable(
                name: "Mail");

            migrationBuilder.DropTable(
                name: "Sending");
        }
    }
}
