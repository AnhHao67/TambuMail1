using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.ViewModels.Common;

namespace TambuMail.ViewModels.Catalog.Mail
{
    public class GetPublicMailPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
