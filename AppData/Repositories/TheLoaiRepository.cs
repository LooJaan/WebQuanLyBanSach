using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppData.Repositories
{
    public class TheLoaiRepository : ITheLoaiRepository
    {
        private readonly MyDbContext _context;

        public TheLoaiRepository(MyDbContext context)
        {
            _context = context;
        }

        // Lấy tất cả thể loại
        public async Task<List<TheLoai>> GetAllTheLoaisAsync()
        {
            return await _context.TheLoais.ToListAsync();
        }

        // Lấy thể loại theo ID
        public async Task<TheLoai> GetTheLoaiByIdAsync(Guid id)
        {
            return await _context.TheLoais.FindAsync(id);
        }

        // Thêm thể loại mới
        public async Task AddTheLoaiAsync(TheLoai theLoai)
        {
            _context.TheLoais.Add(theLoai);
            await _context.SaveChangesAsync();
        }

        // Cập nhật thể loại
        public async Task UpdateTheLoaiAsync(TheLoai theLoai)
        {
            _context.TheLoais.Update(theLoai);
            await _context.SaveChangesAsync();
        }

        // Xóa thể loại
        public async Task DeleteTheLoaiAsync(Guid id)
        {
            var theLoai = await GetTheLoaiByIdAsync(id);
            if (theLoai != null)
            {
                _context.TheLoais.Remove(theLoai);
                await _context.SaveChangesAsync();
            }
        }
    }
}
