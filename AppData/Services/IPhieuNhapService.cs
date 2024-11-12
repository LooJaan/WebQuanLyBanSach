using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public interface IPhieuNhapService
    {
        Task<List<PhieuNhap>> GetAllPhieuNhapsAsync();
        Task<PhieuNhap> GetPhieuNhapByIdAsync(Guid id);
        Task AddPhieuNhapAsync(PhieuNhap phieuNhap);
        Task UpdatePhieuNhapAsync(PhieuNhap phieuNhap);
        Task DeletePhieuNhapAsync(Guid id);
    }
}
