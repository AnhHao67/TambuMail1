using System.Threading.Tasks;
using TambuMail.ViewModels.Catalog.Mail;
using TambuMail.ViewModels.Common;

namespace TambuMail.ApplicationService.Catalog.Mails
{
    public interface IManageMailService //for Admin
    {
        Task<int> Create(MailCreatedRequest request);
        Task<int> Update(MailUpdatedRequest request);
        Task<int> Delete(int MailId);
        Task<MailViewModel> GetById(int mailId);
        Task<PagedViewModel<MailViewModel>> GetAllPaging(GetManageMailPagingRequest request);
    }
}
