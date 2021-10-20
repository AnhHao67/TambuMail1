using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.Data.Enum;

namespace TambuMail.Data.Entities
{
    public class Sending
    {
        public int Id { set; get; }
        public DateTime NgayGui { set; get; }
        public Guid UserID { set; get; }
        public SendingStatus status { set; get; }
        public List<SendingDetail> SendingDetails { get; set; }
        public AppUser AppUser { get; set; }
    }
}
