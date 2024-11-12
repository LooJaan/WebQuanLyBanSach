using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class SachService : ISachService
    {
        private readonly ISachRepository _sachRepository;

        public SachService(ISachRepository sachRepository)
        {
            _sachRepository = sachRepository;
        }

        // Lấy tất cả sách
        public async Task<List<Sach>> GetAllSachsAsync()
        {
            return await _sachRepository.GetAllSachsAsync();
        }

        // Lấy sách theo ID
        public async Task<Sach> GetSachByIdAsync(Guid id)
        {
            return await _sachRepository.GetSachByIdAsync(id);
        }

        // Thêm sách mới
        public async Task AddSachAsync(Sach sach)
        {
            await _sachRepository.AddSachAsync(sach);
        }

        // Cập nhật sách
        public async Task UpdateSachAsync(Sach sach)
        {
            await _sachRepository.UpdateSachAsync(sach);
        }

        // Xóa sách
        public async Task DeleteSachAsync(Guid id)
        {
            await _sachRepository.DeleteSachAsync(id);
        }
    }
}

