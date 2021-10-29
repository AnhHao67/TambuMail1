using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TambuMail.ViewModels.Catalog.Mail;
using TambuMail.ViewModels.Common;

namespace TambuMail.ApplicationService.Catalog.Mails
{
    public interface IPublicMailService //for customer
    {
        Task<PagedViewModel<MailViewModel>> GetAllByCategoryId(GetPublicMailPagingRequest request);
        Task<List<MailViewModel>> GetAll();
    }
}
