using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppData.Repositories
{
    public class HoaDonRepository : IHoaDonRepository
    {
        private readonly MyDbContext _context;

        public HoaDonRepository(MyDbContext context)
        {
            _context = context;
        }

        // Lấy tất cả hóa đơn
        public async Task<List<HoaDon>> GetAllHoaDonsAsync()
        {
            return await _context.HoaDons.ToListAsync();
        }

        // Lấy hóa đơn theo ID
        public async Task<HoaDon> GetHoaDonByIdAsync(Guid id)
        {
            return await _context.HoaDons.FindAsync(id);
        }

        // Thêm hóa đơn mới
        public async Task AddHoaDonAsync(HoaDon hoaDon)
        {
            _context.HoaDons.Add(hoaDon);
            await _context.SaveChangesAsync();
        }

        // Cập nhật hóa đơn
        public async Task UpdateHoaDonAsync(HoaDon hoaDon)
        {
            _context.HoaDons.Update(hoaDon);
            await _context.SaveChangesAsync();
        }

        // Xóa hóa đơn
        public async Task DeleteHoaDonAsync(Guid id)
        {
            var hoaDon = await GetHoaDonByIdAsync(id);
            if (hoaDon != null)
            {
                _context.HoaDons.Remove(hoaDon);
                await _context.SaveChangesAsync();
            }
        }
    }
}

