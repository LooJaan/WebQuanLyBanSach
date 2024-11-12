using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppData.Repositories
{
    public class SachCTRepository : ISachCTRepository
    {
        private readonly MyDbContext _context;

        public SachCTRepository(MyDbContext context)
        {
            _context = context;
        }

        // Lấy tất cả chi tiết sách
        public async Task<List<SachCT>> GetAllSachCTsAsync()
        {
            return await _context.SachCTs.ToListAsync();
        }

        // Lấy chi tiết sách theo ID
        public async Task<SachCT> GetSachCTByIdAsync(Guid id)
        {
            return await _context.SachCTs.FindAsync(id);
        }

        // Thêm chi tiết sách mới
        public async Task AddSachCTAsync(SachCT sachCT)
        {
            _context.SachCTs.Add(sachCT);
            await _context.SaveChangesAsync();
        }

        // Cập nhật chi tiết sách
        public async Task UpdateSachCTAsync(SachCT sachCT)
        {
            _context.SachCTs.Update(sachCT);
            await _context.SaveChangesAsync();
        }

        // Xóa chi tiết sách
        public async Task DeleteSachCTAsync(Guid id)
        {
            var sachCT = await GetSachCTByIdAsync(id);
            if (sachCT != null)
            {
                _context.SachCTs.Remove(sachCT);
                await _context.SaveChangesAsync();
            }
        }
    }
}

