using System;
using System.Collections.Generic;
using System.Text;

namespace TambuMail.Data.Entities
{
    public class GioHang
    {
        public int Id { set; get; }
        public int MailId { set; get; }
        public Guid UserId { set; get; }
        public int SoLuong { set; get; }
        public DateTime NgayTao { set; get; }
        public Mail Mail { get; set; }
        public AppUser AppUser { get; set; }
    }
}
