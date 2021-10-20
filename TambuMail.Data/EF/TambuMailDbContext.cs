using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.Data.Configuration;
using TambuMail.Data.Entities;
using TambuMail.Data.Extension;

namespace TambuMail.Data.EF
{
    public class TambuMailDbContext : IdentityDbContext<AppUser,AppRole,Guid>
    {
        public TambuMailDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new GioHangConfiguration());
            modelBuilder.ApplyConfiguration(new MailConfiguration());
            modelBuilder.ApplyConfiguration(new MailInPhanLoaiConfiguration());
            modelBuilder.ApplyConfiguration(new NgonNguConfiguration());
            modelBuilder.ApplyConfiguration(new PhanLoaiConfiguration());
            modelBuilder.ApplyConfiguration(new PhanLoaiTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new SendingConfiguration());
            modelBuilder.ApplyConfiguration(new SendingDetailConfiguration());


            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());


            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            //data Seeding
            modelBuilder.Seed();
            // base.OnModelCreating(modelBuilder);
        }
        DbSet<Mail> Mails { get; set; }
        DbSet<AppConfig>AppConfigs { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<GioHang> GioHangs { get; set; }
        DbSet<PhanLoai> PhanLoais { get; set; }
        DbSet<Sending>Sendings { get; set; }
        DbSet<SendingDetail> SendingDetails { get; set; }
        DbSet<NgonNgu>NgonNgus { get; set; }
        DbSet <PhanLoaiTranslation> PhanLoaiTranslations { get; set; }
        DbSet<MailInPhanLoai> MailInPhanLoais { get; set; }

    }
}
