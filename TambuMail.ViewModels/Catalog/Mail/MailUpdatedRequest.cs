using System;
using System.Collections.Generic;
using System.Text;

namespace TambuMail.ViewModels.Catalog.Mail
{
    public class MailUpdatedRequest
    {
        public int Id { set; get; }
        public string HoTen { set; get; }
        public string SoDienThoai { set; get; }
        public string DiaChi { set; get; }
        public string SoThich { set; get; }
        public string ThongTin { set; get; }
    }
}
