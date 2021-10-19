using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.Data.Entities;

namespace TambuMail.Data.Configuration
{
    public class MailConfiguration : IEntityTypeConfiguration<Mail>
    {
        public void Configure(EntityTypeBuilder<Mail> builder)
        {
            builder.ToTable("Mail");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.HoTen).HasMaxLength(200).IsRequired();
            builder.Property(x => x.email).HasMaxLength(200).IsRequired();
            builder.Property(x => x.DiaChi).HasMaxLength(200);
            builder.Property(x => x.NgaySinh).IsRequired();
            builder.Property(x => x.SoThich).HasMaxLength(1000);
        }
    }
}
