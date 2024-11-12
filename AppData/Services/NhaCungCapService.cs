using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class NhaCungCapService : INhaCungCapService
    {
        private readonly INhaCungCapRepository _nhaCungCapRepository;

        public NhaCungCapService(INhaCungCapRepository nhaCungCapRepository)
        {
            _nhaCungCapRepository = nhaCungCapRepository;
        }

        // Lấy tất cả nhà cung cấp
        public async Task<List<NhaCungCap>> GetAllNhaCungCapsAsync()
        {
            return await _nhaCungCapRepository.GetAllNhaCungCapsAsync();
        }

        // Lấy nhà cung cấp theo ID
        public async Task<NhaCungCap> GetNhaCungCapByIdAsync(Guid id)
        {
            return await _nhaCungCapRepository.GetNhaCungCapByIdAsync(id);
        }

        // Thêm nhà cung cấp
        public async Task AddNhaCungCapAsync(NhaCungCap nhaCungCap)
        {
            await _nhaCungCapRepository.AddNhaCungCapAsync(nhaCungCap);
        }

        // Cập nhật nhà cung cấp
        public async Task UpdateNhaCungCapAsync(NhaCungCap nhaCungCap)
        {
            await _nhaCungCapRepository.UpdateNhaCungCapAsync(nhaCungCap);
        }

        // Xóa nhà cung cấp
        public async Task DeleteNhaCungCapAsync(Guid id)
        {
            await _nhaCungCapRepository.DeleteNhaCungCapAsync(id);
        }
    }
}

