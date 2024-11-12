using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class HoaDonCTService : IHoaDonCTService
    {
        private readonly IHoaDonCTRepository _hoaDonCTRepository;

        public HoaDonCTService(IHoaDonCTRepository hoaDonCTRepository)
        {
            _hoaDonCTRepository = hoaDonCTRepository;
        }

        // Lấy tất cả chi tiết hóa đơn
        public async Task<List<HoaDonCT>> GetAllHoaDonCTsAsync()
        {
            return await _hoaDonCTRepository.GetAllHoaDonCTsAsync();
        }

        // Lấy chi tiết hóa đơn theo ID
        public async Task<HoaDonCT> GetHoaDonCTByIdAsync(Guid id)
        {
            return await _hoaDonCTRepository.GetHoaDonCTByIdAsync(id);
        }

        // Thêm chi tiết hóa đơn mới
        public async Task AddHoaDonCTAsync(HoaDonCT hoaDonCT)
        {
            await _hoaDonCTRepository.AddHoaDonCTAsync(hoaDonCT);
        }

        // Cập nhật chi tiết hóa đơn
        public async Task UpdateHoaDonCTAsync(HoaDonCT hoaDonCT)
        {
            await _hoaDonCTRepository.UpdateHoaDonCTAsync(hoaDonCT);
        }

        // Xóa chi tiết hóa đơn
        public async Task DeleteHoaDonCTAsync(Guid id)
        {
            await _hoaDonCTRepository.DeleteHoaDonCTAsync(id);
        }
    }
}
