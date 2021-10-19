using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.Data.Entities;

namespace TambuMail.Data.Configuration
{
    public class SendingDetailConfiguration : IEntityTypeConfiguration<SendingDetail>
    {
        public void Configure(EntityTypeBuilder<SendingDetail> builder)
        {
            builder.ToTable("SendingDetails");

            builder.HasKey(x => new { x.SendingId, x.MailId });
            builder.HasOne(x => x.Mail).WithMany(x => x.SendingDetails)
                .HasForeignKey(x => x.MailId);
            builder.HasOne(x => x.Sending).WithMany(x => x.SendingDetails)
                .HasForeignKey(x => x.SendingId);
        }
    }
}
