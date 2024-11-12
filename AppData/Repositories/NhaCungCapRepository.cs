using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppData.Repositories
{
    public class NhaCungCapRepository : INhaCungCapRepository
    {
        private readonly MyDbContext _context;

        public NhaCungCapRepository(MyDbContext context)
        {
            _context = context;
        }

        // Lấy tất cả nhà cung cấp
        public async Task<List<NhaCungCap>> GetAllNhaCungCapsAsync()
        {
            return await _context.NhaCungCaps.ToListAsync();
        }

        // Lấy nhà cung cấp theo ID
        public async Task<NhaCungCap> GetNhaCungCapByIdAsync(Guid id)
        {
            return await _context.NhaCungCaps.FindAsync(id);
        }

        // Thêm nhà cung cấp
        public async Task AddNhaCungCapAsync(NhaCungCap nhaCungCap)
        {
            _context.NhaCungCaps.Add(nhaCungCap);
            await _context.SaveChangesAsync();
        }

        // Cập nhật nhà cung cấp
        public async Task UpdateNhaCungCapAsync(NhaCungCap nhaCungCap)
        {
            _context.NhaCungCaps.Update(nhaCungCap);
            await _context.SaveChangesAsync();
        }

        // Xóa nhà cung cấp
        public async Task DeleteNhaCungCapAsync(Guid id)
        {
            var nhaCungCap = await GetNhaCungCapByIdAsync(id);
            if (nhaCungCap != null)
            {
                _context.NhaCungCaps.Remove(nhaCungCap);
                await _context.SaveChangesAsync();
            }
        }
    }
}

