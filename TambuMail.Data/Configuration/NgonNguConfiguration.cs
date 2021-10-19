using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.Data.Entities;

namespace TambuMail.Data.Configuration
{
    public class NgonNguConfiguration : IEntityTypeConfiguration<NgonNgu>
    {
        public void Configure(EntityTypeBuilder<NgonNgu> builder)
        {
            builder.ToTable("NgonNgu");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().IsUnicode(false).HasMaxLength(5);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
        }
    }
}
