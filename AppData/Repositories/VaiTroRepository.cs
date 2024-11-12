using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace AppData.Repositories
{
    public class VaiTroRepository : IVaiTroRepository
    {
        private readonly MyDbContext _context;

        public VaiTroRepository(MyDbContext context)
        {
            _context = context;
        }

        // Lấy tất cả vai trò
        public async Task<List<VaiTro>> GetAllVaiTrosAsync()
        {
            return await _context.VaiTros.ToListAsync();
        }

        // Lấy vai trò theo ID
        public async Task<VaiTro> GetVaiTroByIdAsync(Guid id)
        {
            return await _context.VaiTros.FindAsync(id);
        }

        // Thêm vai trò mới
        public async Task AddVaiTroAsync(VaiTro vaiTro)
        {
            _context.VaiTros.Add(vaiTro);
            await _context.SaveChangesAsync();
        }

        // Cập nhật vai trò
        public async Task UpdateVaiTroAsync(VaiTro vaiTro)
        {
            _context.VaiTros.Update(vaiTro);
            await _context.SaveChangesAsync();
        }

        // Xóa vai trò
        public async Task DeleteVaiTroAsync(Guid id)
        {
            var vaiTro = await GetVaiTroByIdAsync(id);
            if (vaiTro != null)
            {
                _context.VaiTros.Remove(vaiTro);
                await _context.SaveChangesAsync();
            }
        }
    }
}

