using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TambuMail.ApplicationService.Catalog.Mails;
using TambuMail.ViewModels.Catalog.Mail;

namespace TambuMail.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MailController : ControllerBase
    {
        private readonly IPublicMailService _publicMailService;
        private readonly IManageMailService _manageMailService;
        public MailController(IPublicMailService publicMailService,
            IManageMailService manageMailService)
        {
            _publicMailService = publicMailService;
            _manageMailService = manageMailService;
        }
        //http://localhost:port/mail/public-paging
        [HttpGet("public-paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetPublicMailPagingRequest request)
        {
            var mails = await _publicMailService.GetAllByCategoryId(request);
            return Ok(mails);
        }
        //http://localhost:port/mail/id
        [HttpGet("{mailId}")]
        public async Task<IActionResult> GetById(int mailId)
        {
            var mail = await _manageMailService.GetById(mailId);
            if (mail == null)
                return BadRequest("Cannot find mail");
            return Ok(mail);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]MailCreatedRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _manageMailService.Create(request);
            if (result == 0)
                return BadRequest();
            var mail = await _manageMailService.GetById(result);
            return Created(nameof(GetById), mail);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] MailUpdatedRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var affectedResult = await _manageMailService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
        [HttpDelete("{mailId}")]
        public async Task<IActionResult> Delete(int mailId)
        {
            var affectedResult = await _manageMailService.Delete(mailId);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
    }
}
