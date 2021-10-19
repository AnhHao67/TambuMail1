using System;
using System.Collections.Generic;
using System.Text;

namespace TambuMail.Data.Entities
{
    public class MailInPhanLoai
    {
        public int MailId { get; set; }
        public Mail Mail { get; set; }
        public int PhanLoaiId { get; set; }
        public PhanLoai PhanLoai { get; set; }
    }
}
