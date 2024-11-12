using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public interface INhanVienService
    {
        Task<List<NhanVien>> GetAllNhanViensAsync();
        Task<NhanVien> GetNhanVienByIdAsync(Guid id);
        Task AddNhanVienAsync(NhanVien nhanVien);
        Task UpdateNhanVienAsync(NhanVien nhanVien);
        Task DeleteNhanVienAsync(Guid id);
    }
}
