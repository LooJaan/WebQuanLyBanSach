using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public interface IHoaDonCTService
    {
        Task<List<HoaDonCT>> GetAllHoaDonCTsAsync();
        Task<HoaDonCT> GetHoaDonCTByIdAsync(Guid id);
        Task AddHoaDonCTAsync(HoaDonCT hoaDonCT);
        Task UpdateHoaDonCTAsync(HoaDonCT hoaDonCT);
        Task DeleteHoaDonCTAsync(Guid id);
    }
}
