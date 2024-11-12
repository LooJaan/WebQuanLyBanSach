using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public interface IHoaDonRepository
    {
        Task<List<HoaDon>> GetAllHoaDonsAsync();
        Task<HoaDon> GetHoaDonByIdAsync(Guid id);
        Task AddHoaDonAsync(HoaDon hoaDon);
        Task UpdateHoaDonAsync(HoaDon hoaDon);
        Task DeleteHoaDonAsync(Guid id);
    }
}
