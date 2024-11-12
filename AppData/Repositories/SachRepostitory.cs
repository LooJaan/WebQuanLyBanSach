using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public class SachRepository : ISachRepository
    {
        private readonly MyDbContext _context;

        public SachRepository(MyDbContext context)
        {
            _context = context;
        }

        // Lấy tất cả sách
        public async Task<List<Sach>> GetAllSachsAsync()
        {
            return await _context.Sachs.ToListAsync();
        }

        // Lấy sách theo ID
        public async Task<Sach> GetSachByIdAsync(Guid id)
        {
            return await _context.Sachs.FindAsync(id);
        }

        // Thêm sách mới
        public async Task AddSachAsync(Sach sach)
        {
            _context.Sachs.Add(sach);
            await _context.SaveChangesAsync();
        }

        // Cập nhật sách
        public async Task UpdateSachAsync(Sach sach)
        {
            _context.Sachs.Update(sach);
            await _context.SaveChangesAsync();
        }

        // Xóa sách
        public async Task DeleteSachAsync(Guid id)
        {
            var sach = await GetSachByIdAsync(id);
            _context.Sachs.Remove(sach);
            await _context.SaveChangesAsync();
        }
    }
}
