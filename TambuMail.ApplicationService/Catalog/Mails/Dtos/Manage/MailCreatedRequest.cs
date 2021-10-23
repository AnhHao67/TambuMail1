using System;
using System.Collections.Generic;
using System.Text;

namespace TambuMail.ApplicationService.Catalog.Mails.Dtos.Manage
{
    public class MailCreatedRequest
    {
        public string HoTen { set; get; }
        public string email { set; get; }
        public DateTime NgaySinh { set; get; }
        public string SoDienThoai { set; get; }
        public string DiaChi { set; get; }
        public string SoThich { set; get; }
    }
}
