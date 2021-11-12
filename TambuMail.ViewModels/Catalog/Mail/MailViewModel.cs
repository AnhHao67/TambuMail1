using System;
using System.Collections.Generic;
using System.Text;

namespace TambuMail.ViewModels.Catalog.Mail
{
    public class MailViewModel
    {
        public int Id { set; get; }
        public string HoTen { set; get; }
        public string email { set; get; }
        public DateTime NgaySinh { set; get; }
        public string SoDienThoai { set; get; }
        public string DiaChi { set; get; }
        public string SoThich { set; get; }
        public string ThongTin { set; get; }
    }
}
