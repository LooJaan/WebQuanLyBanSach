using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppData.Repositories
{
    public class HoaDonCTRepository : IHoaDonCTRepository
    {
        private readonly MyDbContext _context;

        public HoaDonCTRepository(MyDbContext context)
        {
            _context = context;
        }

        // Lấy tất cả chi tiết hóa đơn
        public async Task<List<HoaDonCT>> GetAllHoaDonCTsAsync()
        {
            return await _context.HoaDonCTs.ToListAsync();
        }

        // Lấy chi tiết hóa đơn theo ID
        public async Task<HoaDonCT> GetHoaDonCTByIdAsync(Guid id)
        {
            return await _context.HoaDonCTs.FindAsync(id);
        }

        // Thêm chi tiết hóa đơn mới
        public async Task AddHoaDonCTAsync(HoaDonCT hoaDonCT)
        {
            _context.HoaDonCTs.Add(hoaDonCT);
            await _context.SaveChangesAsync();
        }

        // Cập nhật chi tiết hóa đơn
        public async Task UpdateHoaDonCTAsync(HoaDonCT hoaDonCT)
        {
            _context.HoaDonCTs.Update(hoaDonCT);
            await _context.SaveChangesAsync();
        }

        // Xóa chi tiết hóa đơn
        public async Task DeleteHoaDonCTAsync(Guid id)
        {
            var hoaDonCT = await GetHoaDonCTByIdAsync(id);
            if (hoaDonCT != null)
            {
                _context.HoaDonCTs.Remove(hoaDonCT);
                await _context.SaveChangesAsync();
            }
        }
    }
}
