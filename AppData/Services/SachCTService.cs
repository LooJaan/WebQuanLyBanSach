using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class SachCTService : ISachCTService
    {
        private readonly ISachCTRepository _sachCTRepository;

        public SachCTService(ISachCTRepository sachCTRepository)
        {
            _sachCTRepository = sachCTRepository;
        }

        // Lấy tất cả chi tiết sách
        public async Task<List<SachCT>> GetAllSachCTsAsync()
        {
            return await _sachCTRepository.GetAllSachCTsAsync();
        }

        // Lấy chi tiết sách theo ID
        public async Task<SachCT> GetSachCTByIdAsync(Guid id)
        {
            return await _sachCTRepository.GetSachCTByIdAsync(id);
        }

        // Thêm chi tiết sách mới
        public async Task AddSachCTAsync(SachCT sachCT)
        {
            await _sachCTRepository.AddSachCTAsync(sachCT);
        }

        // Cập nhật chi tiết sách
        public async Task UpdateSachCTAsync(SachCT sachCT)
        {
            await _sachCTRepository.UpdateSachCTAsync(sachCT);
        }

        // Xóa chi tiết sách
        public async Task DeleteSachCTAsync(Guid id)
        {
            await _sachCTRepository.DeleteSachCTAsync(id);
        }
    }
}

