using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TambuMail.Data.EF;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TambuMail.ViewModels.Common;
using TambuMail.ViewModels.Catalog.Mail;
namespace TambuMail.ApplicationService.Catalog.Mails
{
    public class PublicMailService : IPublicMailService
    {
        private readonly TambuMailDbContext _context;
        public PublicMailService(TambuMailDbContext context)
        {
            _context = context;
        }

        public async Task<List<MailViewModel>> GetAll()
        {
            var query = from m in _context.Mails
                        join mp in _context.MailInPhanLoais on m.Id equals mp.MailId
                        join p in _context.PhanLoais on mp.PhanLoaiId equals p.Id
                        select new { m, mp };
            var data = await query.Select(x => new MailViewModel()
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
            return data;
        }

        public async Task<PagedViewModel<MailViewModel>> GetAllByCategoryId(GetPublicMailPagingRequest request)
        {
            var query = from m in _context.Mails
                        join mp in _context.MailInPhanLoais on m.Id equals mp.MailId
                        join p in _context.PhanLoais on mp.PhanLoaiId equals p.Id
                        select new { m, mp };
            //filter
            if (request.CategoryId.HasValue && request.CategoryId.Value > 0)
            {
                query = query.Where(m => m.mp.PhanLoaiId == request.CategoryId);
            }
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
    }
}
