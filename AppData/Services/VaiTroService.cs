using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class VaiTroService : IVaiTroService
    {
        private readonly IVaiTroRepository _vaiTroRepository;

        public VaiTroService(IVaiTroRepository vaiTroRepository)
        {
            _vaiTroRepository = vaiTroRepository;
        }

        // Lấy tất cả vai trò
        public async Task<List<VaiTro>> GetAllVaiTrosAsync()
        {
            return await _vaiTroRepository.GetAllVaiTrosAsync();
        }

        // Lấy vai trò theo ID
        public async Task<VaiTro> GetVaiTroByIdAsync(Guid id)
        {
            return await _vaiTroRepository.GetVaiTroByIdAsync(id);
        }

        // Thêm vai trò mới
        public async Task AddVaiTroAsync(VaiTro vaiTro)
        {
            await _vaiTroRepository.AddVaiTroAsync(vaiTro);
        }

        // Cập nhật vai trò
        public async Task UpdateVaiTroAsync(VaiTro vaiTro)
        {
            await _vaiTroRepository.UpdateVaiTroAsync(vaiTro);
        }

        // Xóa vai trò
        public async Task DeleteVaiTroAsync(Guid id)
        {
            await _vaiTroRepository.DeleteVaiTroAsync(id);
        }
    }
}

