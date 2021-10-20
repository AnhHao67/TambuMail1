using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TambuMail.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CongTy { get; set; }
        public List<GioHang> GioHangs { get; set; }
        public List<Sending> Sendings { get; set; }
    }
}
