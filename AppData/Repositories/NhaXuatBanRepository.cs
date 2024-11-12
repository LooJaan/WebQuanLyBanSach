using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppData.Repositories
{
    public class NhaXuatBanRepository : INhaXuatBanRepository
    {
        private readonly MyDbContext _context;

        public NhaXuatBanRepository(MyDbContext context)
        {
            _context = context;
        }

        // Lấy tất cả nhà xuất bản
        public async Task<List<NhaXuatBan>> GetAllNhaXuatBansAsync()
        {
            return await _context.NhaXuatBans.ToListAsync();
        }

        // Lấy nhà xuất bản theo ID
        public async Task<NhaXuatBan> GetNhaXuatBanByIdAsync(Guid id)
        {
            return await _context.NhaXuatBans.FindAsync(id);
        }

        // Thêm nhà xuất bản mới
        public async Task AddNhaXuatBanAsync(NhaXuatBan nhaXuatBan)
        {
            _context.NhaXuatBans.Add(nhaXuatBan);
            await _context.SaveChangesAsync();
        }

        // Cập nhật nhà xuất bản
        public async Task UpdateNhaXuatBanAsync(NhaXuatBan nhaXuatBan)
        {
            _context.NhaXuatBans.Update(nhaXuatBan);
            await _context.SaveChangesAsync();
        }

        // Xóa nhà xuất bản
        public async Task DeleteNhaXuatBanAsync(Guid id)
        {
            var nhaXuatBan = await GetNhaXuatBanByIdAsync(id);
            if (nhaXuatBan != null)
            {
                _context.NhaXuatBans.Remove(nhaXuatBan);
                await _context.SaveChangesAsync();
            }
        }
    }
}
