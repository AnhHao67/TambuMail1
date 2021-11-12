using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TambuMail.ViewModels.System.Users;

namespace TambuMail.ApplicationService.System.Users
{
    public interface IUserService
    {
        Task<string> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
    }
}
