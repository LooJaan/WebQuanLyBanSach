using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppData.Repositories
{
    public class PhieuNhapRepository : IPhieuNhapRepository
    {
        private readonly MyDbContext _context;

        public PhieuNhapRepository(MyDbContext context)
        {
            _context = context;
        }

        // Lấy tất cả phiếu nhập
        public async Task<List<PhieuNhap>> GetAllPhieuNhapsAsync()
        {
            return await _context.PhieuNhaps.ToListAsync();
        }

        // Lấy phiếu nhập theo ID
        public async Task<PhieuNhap> GetPhieuNhapByIdAsync(Guid id)
        {
            return await _context.PhieuNhaps.FindAsync(id);
        }

        // Thêm phiếu nhập mới
        public async Task AddPhieuNhapAsync(PhieuNhap phieuNhap)
        {
            _context.PhieuNhaps.Add(phieuNhap);
            await _context.SaveChangesAsync();
        }

        // Cập nhật phiếu nhập
        public async Task UpdatePhieuNhapAsync(PhieuNhap phieuNhap)
        {
            _context.PhieuNhaps.Update(phieuNhap);
            await _context.SaveChangesAsync();
        }

        // Xóa phiếu nhập
        public async Task DeletePhieuNhapAsync(Guid id)
        {
            var phieuNhap = await GetPhieuNhapByIdAsync(id);
            if (phieuNhap != null)
            {
                _context.PhieuNhaps.Remove(phieuNhap);
                await _context.SaveChangesAsync();
            }
        }
    }
}
