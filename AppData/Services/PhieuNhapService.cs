using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class PhieuNhapService : IPhieuNhapService
    {
        private readonly IPhieuNhapRepository _phieuNhapRepository;

        public PhieuNhapService(IPhieuNhapRepository phieuNhapRepository)
        {
            _phieuNhapRepository = phieuNhapRepository;
        }

        // Lấy tất cả phiếu nhập
        public async Task<List<PhieuNhap>> GetAllPhieuNhapsAsync()
        {
            return await _phieuNhapRepository.GetAllPhieuNhapsAsync();
        }

        // Lấy phiếu nhập theo ID
        public async Task<PhieuNhap> GetPhieuNhapByIdAsync(Guid id)
        {
            return await _phieuNhapRepository.GetPhieuNhapByIdAsync(id);
        }

        // Thêm phiếu nhập mới
        public async Task AddPhieuNhapAsync(PhieuNhap phieuNhap)
        {
            await _phieuNhapRepository.AddPhieuNhapAsync(phieuNhap);
        }

        // Cập nhật phiếu nhập
        public async Task UpdatePhieuNhapAsync(PhieuNhap phieuNhap)
        {
            await _phieuNhapRepository.UpdatePhieuNhapAsync(phieuNhap);
        }

        // Xóa phiếu nhập
        public async Task DeletePhieuNhapAsync(Guid id)
        {
            await _phieuNhapRepository.DeletePhieuNhapAsync(id);
        }
    }
}
