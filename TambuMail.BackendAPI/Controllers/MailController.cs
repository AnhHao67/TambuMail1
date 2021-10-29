using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TambuMail.ApplicationService.Catalog.Mails;

namespace TambuMail.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IPublicMailService _publicMailService;
        public MailController(IPublicMailService publicMailService)
        {
            _publicMailService = publicMailService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var mail = await _publicMailService.GetAll();
            return Ok(mail);
        }
    }
}
