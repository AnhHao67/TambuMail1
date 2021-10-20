using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.Data.Entities;

namespace TambuMail.Data.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.Property(x => x.Ho).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Ten).IsRequired().HasMaxLength(200);
            builder.Property(x => x.NgaySinh).IsRequired();
            builder.Property(x => x.CongTy).IsRequired().HasMaxLength(200);
        }
    }
}
