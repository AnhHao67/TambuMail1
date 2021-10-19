using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.Data.Enum;

namespace TambuMail.Data.Entities
{
    public class PhanLoai
    {
        public int Id { set; get; }
        public bool IsShowOnHome { set; get; }
        public string SortOrder { set; get; }
        public int ParentId { set; get; }
        public Status status { set; get; }
        public List<MailInPhanLoai> MailInPhanLoais { get; set; }
        public List<PhanLoaiTranslation> PhanLoaiTranslations { get; set; }
    }
}
