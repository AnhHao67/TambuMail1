using System;
using System.Collections.Generic;
using System.Text;

namespace TambuMail.ApplicationService.Catalog.Mails.Dtos.Manage
{
    public class MailUpdatedRequest
    {
        public int Id { set; get; }
        public string DiaChi { set; get; }
        public string SoThich { set; get; }
        public string ThongTin { set; get; }
    }
}
