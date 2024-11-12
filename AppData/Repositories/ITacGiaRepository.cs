using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public interface ITacGiaRepository
    {
        Task<IEnumerable<TacGia>> GetAllTacGiasAsync();
        Task<TacGia> GetTacGiaByIdAsync(Guid id);
        Task AddTacGiaAsync(TacGia tacGia);
        Task UpdateTacGiaAsync(TacGia tacGia);
        Task DeleteTacGiaAsync(Guid id);
    }

}
