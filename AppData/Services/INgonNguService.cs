using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class NgonNguService : INgonNguService
    {
        private readonly INgonNguRepository _ngonNguRepository;

        public NgonNguService(INgonNguRepository ngonNguRepository)
        {
            _ngonNguRepository = ngonNguRepository;
        }

        // Lấy tất cả ngôn ngữ
        public async Task<List<NgonNgu>> GetAllNgonNgusAsync()
        {
            return await _ngonNguRepository.GetAllNgonNgusAsync();
        }

        // Lấy ngôn ngữ theo ID
        public async Task<NgonNgu> GetNgonNguByIdAsync(Guid id)
        {
            return await _ngonNguRepository.GetNgonNguByIdAsync(id);
        }

        // Thêm ngôn ngữ mới
        public async Task AddNgonNguAsync(NgonNgu ngonNgu)
        {
            await _ngonNguRepository.AddNgonNguAsync(ngonNgu);
        }

        // Cập nhật ngôn ngữ
        public async Task UpdateNgonNguAsync(NgonNgu ngonNgu)
        {
            await _ngonNguRepository.UpdateNgonNguAsync(ngonNgu);
        }

        // Xóa ngôn ngữ
        public async Task DeleteNgonNguAsync(Guid id)
        {
            await _ngonNguRepository.DeleteNgonNguAsync(id);
        }
    }
}
