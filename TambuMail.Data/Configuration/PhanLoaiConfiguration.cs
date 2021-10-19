using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.Data.Entities;
using TambuMail.Data.Enum;

namespace TambuMail.Data.Configuration
{
    public class PhanLoaiConfiguration : IEntityTypeConfiguration<PhanLoai>
    {
        public void Configure(EntityTypeBuilder<PhanLoai> builder)
        {
            builder.ToTable("PhanLoai");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();


            builder.Property(x => x.status).HasDefaultValue(Status.Active);
        }
    }
}
