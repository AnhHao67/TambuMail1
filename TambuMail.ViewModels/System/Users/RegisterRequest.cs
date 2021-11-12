using System;
using System.Collections.Generic;
using System.Text;

namespace TambuMail.ViewModels.System.Users
{
    public class RegisterRequest
    {
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime NgaySinh { get; set; }     
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CongTy { get; set; }
    }
}
