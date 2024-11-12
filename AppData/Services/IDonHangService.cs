using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public interface IDonHangService
    {
        Task<IEnumerable<DonHang>> GetAllDonHangsAsync();
        Task<DonHang> GetDonHangByIdAsync(Guid id);
        Task AddDonHangAsync(DonHang donHang);
        Task UpdateDonHangAsync(DonHang donHang);
        Task DeleteDonHangAsync(Guid id);
    }

}
