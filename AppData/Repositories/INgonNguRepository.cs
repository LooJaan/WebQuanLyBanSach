using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public interface INgonNguRepository
    {
        Task<List<NgonNgu>> GetAllNgonNgusAsync();
        Task<NgonNgu> GetNgonNguByIdAsync(Guid id);
        Task AddNgonNguAsync(NgonNgu ngonNgu);
        Task UpdateNgonNguAsync(NgonNgu ngonNgu);
        Task DeleteNgonNguAsync(Guid id);
    }
}
