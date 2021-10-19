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
                    SoDienThoai = table.Column<int>(nullable: true),
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
                    SortOrder = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: false),
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
