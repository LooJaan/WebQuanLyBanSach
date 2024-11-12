using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public interface INhaCungCapRepository
    {
        Task<List<NhaCungCap>> GetAllNhaCungCapsAsync();
        Task<NhaCungCap> GetNhaCungCapByIdAsync(Guid id);
        Task AddNhaCungCapAsync(NhaCungCap nhaCungCap);
        Task UpdateNhaCungCapAsync(NhaCungCap nhaCungCap);
        Task DeleteNhaCungCapAsync(Guid id);
    }
}
