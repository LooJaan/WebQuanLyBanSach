using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public interface IHoaDonService
    {
        Task<List<HoaDon>> GetAllHoaDonsAsync();
        Task<HoaDon> GetHoaDonByIdAsync(Guid id);
        Task AddHoaDonAsync(HoaDon hoaDon);
        Task UpdateHoaDonAsync(HoaDon hoaDon);
        Task DeleteHoaDonAsync(Guid id);
    }
}
