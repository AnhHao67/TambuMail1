using System;
using System.Collections.Generic;
using System.Text;

namespace TambuMail.Data.Entities
{
    public class PhanLoaiTranslation
    {
        public int Id { set; get; }
        public int PhanLoaiId { set; get; }
        public string Ten { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string NgonNguId { set; get; }
        public string SeoAlias { set; get; }
        public PhanLoai PhanLoai { get; set; }
        public NgonNgu NgonNgu { get; set; }
    }
}
