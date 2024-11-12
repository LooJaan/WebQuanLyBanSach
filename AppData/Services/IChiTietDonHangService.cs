using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public interface IChiTietDonHangService
    {
        Task<IEnumerable<ChiTietDonHang>> GetAllChiTietDonHangAsync();
        Task<ChiTietDonHang> GetChiTietDonHangByIdAsync(Guid id);
        Task AddChiTietDonHangAsync(ChiTietDonHang chiTietDonHang);
        Task UpdateChiTietDonHangAsync(ChiTietDonHang chiTietDonHang);
        Task DeleteChiTietDonHangAsync(Guid id);
    }

}
