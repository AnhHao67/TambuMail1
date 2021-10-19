using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.Data.Entities;
using TambuMail.Data.Enum;

namespace TambuMail.Data.Extension
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of TambuMail" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of TambuMail" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of TambuMail" }
               );
            modelBuilder.Entity<NgonNgu>().HasData(
                new NgonNgu() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new NgonNgu() { Id = "en-US", Name = "English", IsDefault = false });
            modelBuilder.Entity<PhanLoai>().HasData(
                new PhanLoai()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    status = Status.Active,
                },
                 new PhanLoai()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     status = Status.Active
                 });
            modelBuilder.Entity<PhanLoaiTranslation>().HasData(
                new PhanLoaiTranslation() { Id = 1, PhanLoaiId = 1, Ten = "Chúc mừng sinh nhật", NgonNguId = "vi-VN",
                    SeoAlias = "sinh-nhat", SeoDescription = "mail Chúc mừng sinh nhật", SeoTitle = "mail Chúc mừng sinh nhật" },
                new PhanLoaiTranslation() { Id = 2, PhanLoaiId = 2, Ten = "Happy Birthday", NgonNguId = "en-US",
                    SeoAlias = "happy-birthday", SeoDescription = "Happy Birthday Mail", SeoTitle = "Happy Birthday Mail" }
                );
            modelBuilder.Entity<Mail>().HasData(
       new Mail()
       {
           Id = 1,
           HoTen = "Đinh Anh Hào",
           email = "dinhanhhao2033180037@gmail.com",
           NgaySinh = DateTime.Today,
           DiaChi = "9/9/11 đường số 9, phường Bình Hưng Hoà, quận Bình Tân, thành phố Hồ Chí Minh ",
           SoDienThoai = "0771212342",
           SoThich = "Tiểu thuyết, game, đấu bài Yugioh",
       });
            modelBuilder.Entity<MailInPhanLoai>().HasData(
               new MailInPhanLoai() { MailId = 1, PhanLoaiId = 1 }
               );
        }
    }
}
