using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public class ChiTietDonHangRepository : IChiTietDonHangRepository
    {
        private readonly MyDbContext _context;

        public ChiTietDonHangRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ChiTietDonHang>> GetAllChiTietDonHangAsync()
        {
            return await _context.chiTietDons.ToListAsync();
        }

        public async Task<ChiTietDonHang> GetChiTietDonHangByIdAsync(Guid id)
        {
            return await _context.chiTietDons.FindAsync(id);
        }

        public async Task AddChiTietDonHangAsync(ChiTietDonHang chiTietDonHang)
        {
            await _context.chiTietDons.AddAsync(chiTietDonHang);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateChiTietDonHangAsync(ChiTietDonHang chiTietDonHang)
        {
            _context.chiTietDons.Update(chiTietDonHang);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteChiTietDonHangAsync(Guid id)
        {
            var chiTietDonHang = await _context.chiTietDons.FindAsync(id);
            if (chiTietDonHang != null)
            {
                _context.chiTietDons.Remove(chiTietDonHang);
                await _context.SaveChangesAsync();
            }
        }
    }

}
