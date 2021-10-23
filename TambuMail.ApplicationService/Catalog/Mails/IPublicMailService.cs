using System;
using System.Collections.Generic;
using System.Text;
using TambuMail.ApplicationService.Catalog.Mails.Dtos;
using TambuMail.ApplicationService.Catalog.Mails.Dtos.Public;
using TambuMail.ApplicationService.Dtos;

namespace TambuMail.ApplicationService.Catalog.Mails
{
    public interface IPublicMailService //for customer
    {
        PagedViewModel<MailViewModel> GetAllByCategoryId(GetMailPagingRequest request);
    }
}
