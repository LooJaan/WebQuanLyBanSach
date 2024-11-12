using AppData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Services
{
    public class NhanVienService : INhanVienService
    {
        private readonly INhanVienRepository _nhanVienRepository;

        public NhanVienService(INhanVienRepository nhanVienRepository)
        {
            _nhanVienRepository = nhanVienRepository;
        }

        public async Task<List<NhanVien>> GetAllNhanViensAsync() => await _nhanVienRepository.GetAllNhanViensAsync();

        public async Task<NhanVien> GetNhanVienByIdAsync(Guid id) => await _nhanVienRepository.GetNhanVienByIdAsync(id);

        public async Task AddNhanVienAsync(NhanVien nhanVien) => await _nhanVienRepository.AddNhanVienAsync(nhanVien);

        public async Task UpdateNhanVienAsync(NhanVien nhanVien) => await _nhanVienRepository.UpdateNhanVienAsync(nhanVien);

        public async Task DeleteNhanVienAsync(Guid id) => await _nhanVienRepository.DeleteNhanVienAsync(id);
    }
}
