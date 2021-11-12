using TambuMail.Data.EF;
using TambuMail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TambuMail.ApplicationService.Catalog.Mails;
using TambuMail.Utilities.Exceptions;
using TambuMail.ViewModels.Common;
using TambuMail.ViewModels.Catalog.Mail;

namespace TambuMail.ApplicationService.Catalog
{
    public class ManageMailService : IManageMailService
    {
        private readonly TambuMailDbContext _context;
        public ManageMailService(TambuMailDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(MailCreatedRequest request)
        {
            var mail = new Mail()
            {
                HoTen = request.HoTen,
                email = request.email,
                NgaySinh = request.NgaySinh,
                SoDienThoai = request.SoDienThoai,
                SoThich = request.SoThich,
                DiaChi = request.DiaChi,
                ThongTin = request.ThongTin,
            };
            _context.Mails.Add(mail);
            await _context.SaveChangesAsync();
            return mail.Id;
        }

        public async Task<int> Delete(int MailId)
        {
            var mail = await _context.Mails.FindAsync(MailId);
            if (mail == null) throw new TambuException($"Cannot find a mail: {MailId}");
            _context.Mails.Remove(mail);
            return await _context.SaveChangesAsync();
        }
        public async Task<PagedViewModel<MailViewModel>> GetAllPaging(GetManageMailPagingRequest request)
        {
            // Select join
            var query = from m in _context.Mails
                        join mp in _context.MailInPhanLoais on m.Id equals mp.MailId
                        join p in _context.PhanLoais on mp.PhanLoaiId equals p.Id
                        select new { m, mp };
            //filter
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.m.HoTen.Contains(request.Keyword));
                query = query.Where(x => x.m.email.Contains(request.Keyword));
                query = query.Where(x => x.m.SoThich.Contains(request.Keyword));
            //paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .Select(x => new MailViewModel()
                {
                    Id = x.m.Id,
                    HoTen = x.m.HoTen,
                    NgaySinh = x.m.NgaySinh,
                    email = x.m.email,
                    DiaChi = x.m.DiaChi,
                    SoDienThoai = x.m.SoDienThoai,
                    SoThich = x.m.SoThich,
                    ThongTin = x.m.ThongTin,
                }).ToListAsync();

            //Select and Projection
            var pageResult = new PagedViewModel<MailViewModel>()
            {
                TotalRecord = totalRow,
                Items = data,
            };
            return pageResult;
        }

        public async Task<MailViewModel> GetById(int mailId)
        {
            var mail = await _context.Mails.FindAsync(mailId);
            var mailViewModel = new MailViewModel()
            {
                Id = mail.Id,
                HoTen = mail.HoTen,
                NgaySinh = mail.NgaySinh,
                email = mail.email,
                DiaChi = mail.DiaChi,
                SoDienThoai = mail.SoDienThoai,
                SoThich = mail.SoThich,
                ThongTin = mail.ThongTin,
            };
            return mailViewModel;
        }

        public async Task<int> Update(MailUpdatedRequest request)
        {
            var mail = await _context.Mails.FindAsync(request.Id);
            if (mail == null) throw new TambuException($"Cannot find  a mail with id: {request.Id}");
            mail.HoTen = request.HoTen;
            mail.SoDienThoai = request.SoDienThoai;
            mail.SoThich = request.SoThich;
            mail.DiaChi = request.DiaChi;
            mail.ThongTin = request.ThongTin;
            return await _context.SaveChangesAsync();
        }
    }
}
