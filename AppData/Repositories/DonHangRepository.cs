using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public class DonHangRepository : IDonHangRepository
    {
        private readonly MyDbContext _context;

        public DonHangRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DonHang>> GetAllDonHangsAsync()
        {
            return await _context.donHangs.ToListAsync();
        }

        public async Task<DonHang> GetDonHangByIdAsync(Guid id)
        {
            return await _context.donHangs.FindAsync(id);
        }

        public async Task AddDonHangAsync(DonHang donHang)
        {
            await _context.donHangs.AddAsync(donHang);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateDonHangAsync(DonHang donHang)
        {
            _context.donHangs.Update(donHang);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteDonHangAsync(Guid id)
        {
            var donHang = await _context.donHangs.FindAsync(id);
            if (donHang != null)
            {
                _context.donHangs.Remove(donHang);
                await _context.SaveChangesAsync();
            }
        }
    }

}
