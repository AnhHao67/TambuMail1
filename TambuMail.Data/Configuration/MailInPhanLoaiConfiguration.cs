using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.Data.Entities;

namespace TambuMail.Data.Configuration
{
    public class MailInPhanLoaiConfiguration : IEntityTypeConfiguration<MailInPhanLoai>
    {
        public void Configure(EntityTypeBuilder<MailInPhanLoai> builder)
        {
            builder.HasKey(t => new { t.PhanLoaiId, t.MailId });
            builder.ToTable("ChienDichInCategory");
            builder.HasOne(t => t.Mail).WithMany(pc => pc.MailInPhanLoais)
                .HasForeignKey(pc => pc.MailId);
            builder.HasOne(t => t.PhanLoai).WithMany(pc => pc.MailInPhanLoais)
                .HasForeignKey(pc => pc.PhanLoaiId);
        }
    }
}
