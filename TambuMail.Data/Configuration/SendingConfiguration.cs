using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.Data.Entities;

namespace TambuMail.Data.Configuration
{
    public class SendingConfiguration : IEntityTypeConfiguration<Sending>
    {
        public void Configure(EntityTypeBuilder<Sending> builder)
        {
            builder.ToTable("Sending");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.NgayGui);

        }
    }
}
