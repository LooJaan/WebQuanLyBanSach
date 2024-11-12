using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public interface IPhieuNhapCTService
    {
        Task<List<PhieuNhapCT>> GetAllPhieuNhapCTsAsync();
        Task<PhieuNhapCT> GetPhieuNhapCTByIdAsync(Guid id);
        Task AddPhieuNhapCTAsync(PhieuNhapCT phieuNhapCT);
        Task UpdatePhieuNhapCTAsync(PhieuNhapCT phieuNhapCT);
        Task DeletePhieuNhapCTAsync(Guid id);
    }
}
