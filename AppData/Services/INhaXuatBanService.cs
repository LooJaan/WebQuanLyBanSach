using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public interface INhaXuatBanService
    {
        Task<List<NhaXuatBan>> GetAllNhaXuatBansAsync();
        Task<NhaXuatBan> GetNhaXuatBanByIdAsync(Guid id);
        Task AddNhaXuatBanAsync(NhaXuatBan nhaXuatBan);
        Task UpdateNhaXuatBanAsync(NhaXuatBan nhaXuatBan);
        Task DeleteNhaXuatBanAsync(Guid id);
    }
}
