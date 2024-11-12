using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class KhachHangService : IKhachHangService
    {
        private readonly IKhachHangRepository _khachHangRepository;

        public KhachHangService(IKhachHangRepository khachHangRepository)
        {
            _khachHangRepository = khachHangRepository;
        }

        // Lấy tất cả khách hàng
        public async Task<List<KhachHang>> GetAllKhachHangsAsync()
        {
            return await _khachHangRepository.GetAllKhachHangsAsync();
        }

        // Lấy khách hàng theo ID
        public async Task<KhachHang> GetKhachHangByIdAsync(Guid id)
        {
            return await _khachHangRepository.GetKhachHangByIdAsync(id);
        }

        // Thêm khách hàng mới
        public async Task AddKhachHangAsync(KhachHang khachHang)
        {
            await _khachHangRepository.AddKhachHangAsync(khachHang);
        }

        // Cập nhật khách hàng
        public async Task UpdateKhachHangAsync(KhachHang khachHang)
        {
            await _khachHangRepository.UpdateKhachHangAsync(khachHang);
        }

        // Xóa khách hàng
        public async Task DeleteKhachHangAsync(Guid id)
        {
            await _khachHangRepository.DeleteKhachHangAsync(id);
        }
    }
}
