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
        public DbSet<Mail> Mails { get; set; }
        public DbSet<AppConfig>AppConfigs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<PhanLoai> PhanLoais { get; set; }
        public DbSet<Sending>Sendings { get; set; }
        public DbSet<SendingDetail> SendingDetails { get; set; }
        public DbSet<NgonNgu>NgonNgus { get; set; }
        public DbSet <PhanLoaiTranslation> PhanLoaiTranslations { get; set; }
        public DbSet<MailInPhanLoai> MailInPhanLoais { get; set; }

    }
}
