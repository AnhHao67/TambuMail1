using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.Data.Entities;

namespace TambuMail.Data.Configuration
{
    public class PhanLoaiTranslationConfiguration : IEntityTypeConfiguration<PhanLoaiTranslation>
    {
        public void Configure(EntityTypeBuilder<PhanLoaiTranslation> builder)
        {
            builder.ToTable("PhanLoaiTranslation");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();


            builder.Property(x => x.Ten).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoDescription).HasMaxLength(500);

            builder.Property(x => x.SeoTitle).HasMaxLength(200);

            builder.Property(x => x.NgonNguId).IsUnicode(false).IsRequired().HasMaxLength(5);
            builder.HasOne(x => x.NgonNgu).WithMany(x => x.PhanLoaiTranslations)
                .HasForeignKey(x => x.NgonNguId);
            builder.HasOne(x => x.PhanLoai).WithMany(x => x.PhanLoaiTranslations)
                .HasForeignKey(x => x.PhanLoaiId);
        }
    }
}
