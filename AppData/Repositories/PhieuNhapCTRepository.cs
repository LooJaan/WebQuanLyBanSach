using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppData.Repositories
{
    public class PhieuNhapCTRepository : IPhieuNhapCTRepository
    {
        private readonly MyDbContext _context;

        public PhieuNhapCTRepository(MyDbContext context)
        {
            _context = context;
        }

        // Lấy tất cả chi tiết phiếu nhập
        public async Task<List<PhieuNhapCT>> GetAllPhieuNhapCTsAsync()
        {
            return await _context.PhieuNhapCTs.ToListAsync();
        }

        // Lấy chi tiết phiếu nhập theo ID
        public async Task<PhieuNhapCT> GetPhieuNhapCTByIdAsync(Guid id)
        {
            return await _context.PhieuNhapCTs.FindAsync(id);
        }

        // Thêm chi tiết phiếu nhập
        public async Task AddPhieuNhapCTAsync(PhieuNhapCT phieuNhapCT)
        {
            _context.PhieuNhapCTs.Add(phieuNhapCT);
            await _context.SaveChangesAsync();
        }

        // Cập nhật chi tiết phiếu nhập
        public async Task UpdatePhieuNhapCTAsync(PhieuNhapCT phieuNhapCT)
        {
            _context.PhieuNhapCTs.Update(phieuNhapCT);
            await _context.SaveChangesAsync();
        }

        // Xóa chi tiết phiếu nhập
        public async Task DeletePhieuNhapCTAsync(Guid id)
        {
            var phieuNhapCT = await GetPhieuNhapCTByIdAsync(id);
            if (phieuNhapCT != null)
            {
                _context.PhieuNhapCTs.Remove(phieuNhapCT);
                await _context.SaveChangesAsync();
            }
        }
    }
}
