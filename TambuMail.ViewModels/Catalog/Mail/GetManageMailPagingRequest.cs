using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.ViewModels.Common;

namespace TambuMail.ViewModels.Catalog.Mail
{
    public class GetManageMailPagingRequest :PagingRequestBase
    {
        public string Keyword { get; set; }
        public int PhanLoaiId { get; set; }
    }
}
