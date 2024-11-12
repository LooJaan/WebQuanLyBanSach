using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppData.Repositories
{
    public class NhanVienRepository : INhanVienRepository
    {
        private readonly MyDbContext _context;

        public NhanVienRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<NhanVien>> GetAllNhanViensAsync() => await _context.NhanViens.ToListAsync();

        public async Task<NhanVien> GetNhanVienByIdAsync(Guid id) => await _context.NhanViens.FindAsync(id);

        public async Task AddNhanVienAsync(NhanVien nhanVien)
        {
            _context.NhanViens.Add(nhanVien);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateNhanVienAsync(NhanVien nhanVien)
        {
            _context.NhanViens.Update(nhanVien);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteNhanVienAsync(Guid id)
        {
            var nhanVien = await GetNhanVienByIdAsync(id);
            if (nhanVien != null)
            {
                _context.NhanViens.Remove(nhanVien);
                await _context.SaveChangesAsync();
            }
        }
    }
}
