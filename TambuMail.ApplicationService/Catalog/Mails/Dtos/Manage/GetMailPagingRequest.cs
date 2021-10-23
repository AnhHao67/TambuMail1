using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.ApplicationService.Dtos;

namespace TambuMail.ApplicationService.Catalog.Mails.Dtos.Manage
{
    public class GetMailPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public int PhanLoaiId { get; set; }
    }
}
