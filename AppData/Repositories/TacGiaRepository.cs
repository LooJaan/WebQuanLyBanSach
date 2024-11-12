using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public class TacGiaRepository : ITacGiaRepository
    {
        private readonly MyDbContext _context;

        public TacGiaRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TacGia>> GetAllTacGiasAsync()
        {
            return await _context.tacGias.ToListAsync();
        }

        public async Task<TacGia> GetTacGiaByIdAsync(Guid id)
        {
            return await _context.tacGias.FindAsync(id);
        }

        public async Task AddTacGiaAsync(TacGia tacGia)
        {
            await _context.tacGias.AddAsync(tacGia);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTacGiaAsync(TacGia tacGia)
        {
            _context.tacGias.Update(tacGia);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTacGiaAsync(Guid id)
        {
            var tacGia = await _context.tacGias.FindAsync(id);
            if (tacGia != null)
            {
                _context.tacGias.Remove(tacGia);
                await _context.SaveChangesAsync();
            }
        }
    }

}
