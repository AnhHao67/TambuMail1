using System;
using System.Collections.Generic;
using System.Text;

namespace TambuMail.Data.Entities
{
    public class SendingDetail
    {
        public int SendingId { set; get; }
        public int MailId { set; get; }
        public int SoLuong { set; get; }
        public Mail Mail { get; set; }
        public Sending Sending { get; set; }
    }
}
