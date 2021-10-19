﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TambuMail.Data.EF;

namespace TambuMail.Data.Migrations
{
    [DbContext(typeof(TambuMailDbContext))]
    partial class TambuMailDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TambuMail.Data.Entities.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("AppConfig");
                });

            modelBuilder.Entity("TambuMail.Data.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("TambuMail.Data.Entities.GioHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MailId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MailId");

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("TambuMail.Data.Entities.Mail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SoDienThoai")
                        .HasColumnType("int");

                    b.Property<string>("SoThich")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("ThongTin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Mail");
                });

            modelBuilder.Entity("TambuMail.Data.Entities.MailInPhanLoai", b =>
                {
                    b.Property<int>("PhanLoaiId")
                        .HasColumnType("int");

                    b.Property<int>("MailId")
                        .HasColumnType("int");

                    b.HasKey("PhanLoaiId", "MailId");

                    b.HasIndex("MailId");

                    b.ToTable("ChienDichInCategory");
                });

            modelBuilder.Entity("TambuMail.Data.Entities.NgonNgu", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("NgonNgu");
                });

            modelBuilder.Entity("TambuMail.Data.Entities.PhanLoai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsShowOnHome")
                        .HasColumnType("bit");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("SortOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.ToTable("PhanLoai");
                });

            modelBuilder.Entity("TambuMail.Data.Entities.PhanLoaiTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NgonNguId")
                        .IsRequired()
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<int>("PhanLoaiId")
                        .HasColumnType("int");

                    b.Property<string>("SeoAlias")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("SeoDescription")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("SeoTitle")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("NgonNguId");

                    b.HasIndex("PhanLoaiId");

                    b.ToTable("PhanLoaiTranslation");
                });

            modelBuilder.Entity("TambuMail.Data.Entities.Sending", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("NgayGui")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sending");
                });

            modelBuilder.Entity("TambuMail.Data.Entities.SendingDetail", b =>
                {
                    b.Property<int>("SendingId")
                        .HasColumnType("int");

                    b.Property<int>("MailId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("SendingId", "MailId");

                    b.HasIndex("MailId");

                    b.ToTable("SendingDetails");
                });

            modelBuilder.Entity("TambuMail.Data.Entities.GioHang", b =>
                {
                    b.HasOne("TambuMail.Data.Entities.Mail", "Mail")
                        .WithMany("GioHangs")
                        .HasForeignKey("MailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TambuMail.Data.Entities.MailInPhanLoai", b =>
                {
                    b.HasOne("TambuMail.Data.Entities.Mail", "Mail")
                        .WithMany("MailInPhanLoais")
                        .HasForeignKey("MailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TambuMail.Data.Entities.PhanLoai", "PhanLoai")
                        .WithMany("MailInPhanLoais")
                        .HasForeignKey("PhanLoaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TambuMail.Data.Entities.PhanLoaiTranslation", b =>
                {
                    b.HasOne("TambuMail.Data.Entities.NgonNgu", "NgonNgu")
                        .WithMany("PhanLoaiTranslations")
                        .HasForeignKey("NgonNguId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TambuMail.Data.Entities.PhanLoai", "PhanLoai")
                        .WithMany("PhanLoaiTranslations")
                        .HasForeignKey("PhanLoaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TambuMail.Data.Entities.SendingDetail", b =>
                {
                    b.HasOne("TambuMail.Data.Entities.Mail", "Mail")
                        .WithMany("SendingDetails")
                        .HasForeignKey("MailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TambuMail.Data.Entities.Sending", "Sending")
                        .WithMany("SendingDetails")
                        .HasForeignKey("SendingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
