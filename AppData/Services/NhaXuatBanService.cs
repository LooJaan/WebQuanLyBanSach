using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class NhaXuatBanService : INhaXuatBanService
    {
        private readonly INhaXuatBanRepository _nhaXuatBanRepository;

        public NhaXuatBanService(INhaXuatBanRepository nhaXuatBanRepository)
        {
            _nhaXuatBanRepository = nhaXuatBanRepository;
        }

        // Lấy tất cả nhà xuất bản
        public async Task<List<NhaXuatBan>> GetAllNhaXuatBansAsync()
        {
            return await _nhaXuatBanRepository.GetAllNhaXuatBansAsync();
        }

        // Lấy nhà xuất bản theo ID
        public async Task<NhaXuatBan> GetNhaXuatBanByIdAsync(Guid id)
        {
            return await _nhaXuatBanRepository.GetNhaXuatBanByIdAsync(id);
        }

        // Thêm nhà xuất bản mới
        public async Task AddNhaXuatBanAsync(NhaXuatBan nhaXuatBan)
        {
            await _nhaXuatBanRepository.AddNhaXuatBanAsync(nhaXuatBan);
        }

        // Cập nhật nhà xuất bản
        public async Task UpdateNhaXuatBanAsync(NhaXuatBan nhaXuatBan)
        {
            await _nhaXuatBanRepository.UpdateNhaXuatBanAsync(nhaXuatBan);
        }

        // Xóa nhà xuất bản
        public async Task DeleteNhaXuatBanAsync(Guid id)
        {
            await _nhaXuatBanRepository.DeleteNhaXuatBanAsync(id);
        }
    }
}
