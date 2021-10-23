using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TambuMail.ApplicationService.Catalog.Mails.Dtos;
using TambuMail.ApplicationService.Catalog.Mails.Dtos.Manage;
using TambuMail.ApplicationService.Dtos;

namespace TambuMail.ApplicationService.Catalog.Mails
{
    public interface IManageMailService //for Admin
    {
        Task<int> Create(MailCreatedRequest request);
        Task<int> Update(MailUpdatedRequest request);
        Task<int> Delete(int MailId);
        Task<List<MailViewModel>> GetAll();
        Task<PagedViewModel<MailViewModel>> GetAllPaging(GetMailPagingRequest request);
    }
}
