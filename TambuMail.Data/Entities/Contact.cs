using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.Data.Enum;

namespace TambuMail.Data.Entities
{
    public class Contact
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string message { set; get; }
        public Status status { set; get; }
    }
}
