using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppData.Repositories
{
    public class NgonNguRepository : INgonNguRepository
    {
        private readonly MyDbContext _context;

        public NgonNguRepository(MyDbContext context)
        {
            _context = context;
        }

        // Lấy tất cả ngôn ngữ
        public async Task<List<NgonNgu>> GetAllNgonNgusAsync()
        {
            return await _context.NgonNgus.ToListAsync();
        }

        // Lấy ngôn ngữ theo ID
        public async Task<NgonNgu> GetNgonNguByIdAsync(Guid id)
        {
            return await _context.NgonNgus.FindAsync(id);
        }

        // Thêm ngôn ngữ mới
        public async Task AddNgonNguAsync(NgonNgu ngonNgu)
        {
            ngonNgu.Id = Guid.NewGuid();
            _context.NgonNgus.Add(ngonNgu);
            await _context.SaveChangesAsync();
        }

        // Cập nhật ngôn ngữ
        public async Task UpdateNgonNguAsync(NgonNgu ngonNgu)
        {
            _context.NgonNgus.Update(ngonNgu);
            await _context.SaveChangesAsync();
        }


        // Xóa ngôn ngữ
        public async Task DeleteNgonNguAsync(Guid id)
        {
            var ngonNgu = await GetNgonNguByIdAsync(id);
            if (ngonNgu != null)
            {
                _context.NgonNgus.Remove(ngonNgu);
                await _context.SaveChangesAsync();
            }
        }
    }
}
