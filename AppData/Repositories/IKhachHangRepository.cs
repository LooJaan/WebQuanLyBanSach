using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repositories
{
    public interface IKhachHangRepository
    {
        Task<List<KhachHang>> GetAllKhachHangsAsync();
        Task<KhachHang> GetKhachHangByIdAsync(Guid id);
        Task AddKhachHangAsync(KhachHang khachHang);
        Task UpdateKhachHangAsync(KhachHang khachHang);
        Task DeleteKhachHangAsync(Guid id);
    }
}

