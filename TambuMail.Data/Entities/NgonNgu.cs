using System;
using System.Collections.Generic;
using System.Text;

namespace TambuMail.Data.Entities
{
    public class NgonNgu
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }
        public List<PhanLoaiTranslation> PhanLoaiTranslations { get; set; }
    }
}
