using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class HoaDonService : IHoaDonService
    {
        private readonly IHoaDonRepository _hoaDonRepository;

        public HoaDonService(IHoaDonRepository hoaDonRepository)
        {
            _hoaDonRepository = hoaDonRepository;
        }

        // Lấy tất cả hóa đơn
        public async Task<List<HoaDon>> GetAllHoaDonsAsync()
        {
            return await _hoaDonRepository.GetAllHoaDonsAsync();
        }

        // Lấy hóa đơn theo ID
        public async Task<HoaDon> GetHoaDonByIdAsync(Guid id)
        {
            return await _hoaDonRepository.GetHoaDonByIdAsync(id);
        }

        // Thêm hóa đơn mới
        public async Task AddHoaDonAsync(HoaDon hoaDon)
        {
            await _hoaDonRepository.AddHoaDonAsync(hoaDon);
        }

        // Cập nhật hóa đơn
        public async Task UpdateHoaDonAsync(HoaDon hoaDon)
        {
            await _hoaDonRepository.UpdateHoaDonAsync(hoaDon);
        }

        // Xóa hóa đơn
        public async Task DeleteHoaDonAsync(Guid id)
        {
            await _hoaDonRepository.DeleteHoaDonAsync(id);
        }
    }
}
