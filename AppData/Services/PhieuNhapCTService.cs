using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class PhieuNhapCTService : IPhieuNhapCTService
    {
        private readonly IPhieuNhapCTRepository _phieuNhapCTRepository;

        public PhieuNhapCTService(IPhieuNhapCTRepository phieuNhapCTRepository)
        {
            _phieuNhapCTRepository = phieuNhapCTRepository;
        }

        // Lấy tất cả chi tiết phiếu nhập
        public async Task<List<PhieuNhapCT>> GetAllPhieuNhapCTsAsync()
        {
            return await _phieuNhapCTRepository.GetAllPhieuNhapCTsAsync();
        }

        // Lấy chi tiết phiếu nhập theo ID
        public async Task<PhieuNhapCT> GetPhieuNhapCTByIdAsync(Guid id)
        {
            return await _phieuNhapCTRepository.GetPhieuNhapCTByIdAsync(id);
        }

        // Thêm chi tiết phiếu nhập
        public async Task AddPhieuNhapCTAsync(PhieuNhapCT phieuNhapCT)
        {
            await _phieuNhapCTRepository.AddPhieuNhapCTAsync(phieuNhapCT);
        }

        // Cập nhật chi tiết phiếu nhập
        public async Task UpdatePhieuNhapCTAsync(PhieuNhapCT phieuNhapCT)
        {
            await _phieuNhapCTRepository.UpdatePhieuNhapCTAsync(phieuNhapCT);
        }

        // Xóa chi tiết phiếu nhập
        public async Task DeletePhieuNhapCTAsync(Guid id)
        {
            await _phieuNhapCTRepository.DeletePhieuNhapCTAsync(id);
        }
    }
}
