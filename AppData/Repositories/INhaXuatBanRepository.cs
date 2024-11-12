using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public interface INhaXuatBanRepository
    {
        Task<List<NhaXuatBan>> GetAllNhaXuatBansAsync();
        Task<NhaXuatBan> GetNhaXuatBanByIdAsync(Guid id);
        Task AddNhaXuatBanAsync(NhaXuatBan nhaXuatBan);
        Task UpdateNhaXuatBanAsync(NhaXuatBan nhaXuatBan);
        Task DeleteNhaXuatBanAsync(Guid id);
    }
}
