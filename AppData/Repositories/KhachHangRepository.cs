using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppData.Repositories
{
    public class KhachHangRepository : IKhachHangRepository
    {
        private readonly MyDbContext _context;

        public KhachHangRepository(MyDbContext context)
        {
            _context = context;
        }

        // Lấy tất cả khách hàng
        public async Task<List<KhachHang>> GetAllKhachHangsAsync()
        {
            return await _context.KhachHangs.ToListAsync();
        }

        // Lấy khách hàng theo ID
        public async Task<KhachHang> GetKhachHangByIdAsync(Guid id)
        {
            return await _context.KhachHangs.FindAsync(id);
        }

        // Thêm khách hàng mới
        public async Task AddKhachHangAsync(KhachHang khachHang)
        {
            _context.KhachHangs.Add(khachHang);
            await _context.SaveChangesAsync();
        }

        // Cập nhật khách hàng
        public async Task UpdateKhachHangAsync(KhachHang khachHang)
        {
            _context.KhachHangs.Update(khachHang);
            await _context.SaveChangesAsync();
        }

        // Xóa khách hàng
        public async Task DeleteKhachHangAsync(Guid id)
        {
            var khachHang = await GetKhachHangByIdAsync(id);
            if (khachHang != null)
            {
                _context.KhachHangs.Remove(khachHang);
                await _context.SaveChangesAsync();
            }
        }
    }
}
